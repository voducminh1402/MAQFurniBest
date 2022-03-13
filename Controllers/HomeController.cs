using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MAQFurni.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MAQFurni.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly FurnitureShopContext _context;

        public HomeController(FurnitureShopContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [ActionName("Index")]
        public async Task<IActionResult> IndexAsync()
        {
            IndexViewModel ivm = new IndexViewModel();
            ivm.ListCategory = await _context.Categories.ToListAsync();
            ivm.ListProduct = await _context.Products.ToListAsync();
            return View(ivm);
        }

        public IActionResult Search(string search)
        {
            List<Product> searchList = new List<Product>();
            searchList = _context.Products.Where(p => p.ProductName.Contains(search)).ToList();

            ViewBag.ProductList = searchList;
            ViewBag.Search = search;
            ViewBag.Cond = "Relevance";

            return View("SearchProduct");
        }

        public IActionResult DetailProduct(string productId)
        {
            Product productDetail = _context.Products.Find(productId);
            int categoryId = productDetail.CategoryId;
            List<Product> sameProduct = _context.Products.OrderBy(p => Guid.NewGuid()).Take(7).ToList();
            List<Product> sameCate = _context.Products.Where(p => p.CategoryId == categoryId).ToList();

            ProductDetailList productDetailModel = new ProductDetailList();
            productDetailModel.Product = productDetail;
            productDetailModel.SameProduct = sameProduct;
            productDetailModel.SameCate = sameCate;

            ViewBag.ProductModel = productDetailModel;

            return View("ProductDetail");
        }

        public IActionResult FilterCategory(int categoryId)
        {
            List<Product> list = _context.Products.Where(p => p.CategoryId == categoryId).ToList();

            ViewBag.ProductList = list;
            ViewBag.Cond = "Relevance";
            return View("FilterCategory");
        }

        [HttpGet]
        [ActionName("Shopping")]
        public IActionResult Shopping(string condition)
        {
            List<Product> listProduct = new List<Product>();

            if (condition == null)
            {
                condition = "Relevance";
            }

            if (condition.Equals("1"))
            {
                listProduct = _context.Products.OrderBy(p => p.ProductName).ToList();
            }
            else if (condition.Equals("2"))
            {
                listProduct = _context.Products.OrderByDescending(p => p.ProductName).ToList();
            }
            else if (condition.Equals("3"))
            {
                listProduct = _context.Products.OrderByDescending(p => p.ProductPrice).ToList();
            }
            else if (condition.Equals("4"))
            {
                listProduct = _context.Products.OrderBy(p => p.ProductPrice).ToList();
            }
            else
            {
                listProduct = _context.Products.ToList();
            }

            // List<Category> listCate = _context.Categories.ToList();
            var categoryView = _context.Categories.Select(c => new CategoryView
            {
                Id = c.CategoryId,
                Name = c.CategoryName,
                Numbers = c.Products.Count()
            }).ToList();

            ViewBag.ProductList = listProduct;
            ViewBag.CategoryView = categoryView;
            ViewBag.Cond = "Relevance";

            return View("Shopping");
        }


        [HttpGet]
        public IActionResult Sort(string condition, string search)
        {
            List<Product> searchList = new List<Product>();

            if (condition == null)
            {
                condition = "Relevance";
            }

            if (condition.Equals("1"))
            {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderBy(p => p.ProductName).ToList();
            }
            else if (condition.Equals("2"))
            {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderByDescending(p => p.ProductName).ToList();
            }
            else if (condition.Equals("3"))
            {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderByDescending(p => p.ProductPrice).ToList();
            }
            else if (condition.Equals("4"))
            {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderBy(p => p.ProductPrice).ToList();
            }
            else
            {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).ToList();
            }

            ViewBag.ProductList = searchList;
            ViewBag.Search = search;
            ViewBag.Cond = condition;

            return View("SearchProduct");
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet("check-out")]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpGet("check-out-success")]
        public IActionResult CheckoutSuccess()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // public User CheckOut()
        // {
        //     return _user;
        // }
        // private class ProductOrder{
        //     public string id { get; set; }
        //     public string image { get; set; } 
        //     public string name { get; set; }
        //     public decimal price { get; set; }
        //     public int quantity { get; set; }
        // }
        [HttpPost("cart/check-out")]
        [ActionName("AddOrder")]
        public async Task<IActionResult> CheckOutAsync(string cart, string firstName, string lastName, string city, string phone, string state, string address, string message, string email)
        {
            var userId = _userManager.GetUserId(User);
            if (!_signInManager.IsSignedIn(User))
                return Redirect("https://localhost:5001/login");
            Console.WriteLine($"{cart} - {phone} - {firstName + lastName} - {address} - {city} - {state}");
            if (cart != null)
            {
                dynamic json = JsonConvert.DeserializeObject(cart);
                Console.WriteLine(json);
                string id;
                decimal price;
                int quantity;
                decimal totalPrice = 0;
                List<Product> products = await _context.Products.ToListAsync();

                Dictionary<Product, int> dic = new Dictionary<Product, int>();
                foreach (var o in json)
                {
                    id = o["id"];
                    string p = o["price"];
                    string q = o["quantity"];
                    price = decimal.Parse(p);
                    quantity = int.Parse(q);
                    Console.WriteLine($"{id} - {price} - {quantity}");
                    totalPrice += price * quantity;
                    Product pro = await _context.Products.SingleOrDefaultAsync(o => o.ProductId.Equals(id));
                    if (pro.Quantity == 0)
                    {
                        ViewBag.ProductId = id;
                        ViewBag.ProductQuantity = 0;
                        return View("Checkout");
                    }
                    if (pro.Quantity < quantity)
                    {
                        ViewBag.ProductId = id;
                        ViewBag.ProductQuantity = pro.Quantity;
                        return View("Checkout");
                    }
                    dic.Add(pro, quantity);
                }

                Guid orderId = Guid.NewGuid();
                Order order = new Order
                {
                    OrderId = orderId.ToString(),
                    CreateDate = DateTime.Now,
                    TotalPrice = totalPrice,
                    UserId = userId
                };
                _context.Orders.Add(order);
                _context.SaveChanges();

                foreach (KeyValuePair<Product, int> kvp in dic)
                {
                    Guid detailId = Guid.NewGuid();
                    OrderDetail detail = new OrderDetail
                    {
                        DetailId = detailId.ToString(),
                        DetailPrice = kvp.Key.ProductPrice,
                        OrderId = orderId.ToString(),
                        ProductId = kvp.Key.ProductId,
                        Quantity = kvp.Value
                    };
                    _context.OrderDetails.Add(detail);
                    _context.SaveChanges();
                    kvp.Key.Quantity -= kvp.Value;
                    if (kvp.Key.Quantity == 0)
                    {
                        kvp.Key.AvailableId = 2;
                    }
                    _context.Update<Product>(kvp.Key);
                    _context.SaveChanges();
                }
                ShippingInfo shipping = new ShippingInfo
                {
                    FullName = firstName + " " + lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Phone = phone,
                    Note = message,
                    OrderId = orderId.ToString(),
                    StatusId = 3
                };
                _context.ShippingInfos.Add(shipping);
                _context.SaveChanges();
            }


            // foreach (var pro in products)
            //     foreach (var p in cartProduct)
            //     {

            //         int availableId = p.AvailableId;
            //         int quantityNew = pro.Quantity - p.Quantity;
            //         if (quantityNew == 0)
            //         {
            //             availableId = 2;
            //         }
            //         Product product = new Product
            //         {
            //             ProductId = p.ProductId,
            //             ProductImage = p.ProductImage,
            //             ProductName = p.ProductName,
            //             ProductPrice = p.ProductPrice,
            //             Quantity = quantityNew,
            //             Description = p.Description,
            //             CreateDate = p.CreateDate,
            //             AvailableId = availableId,
            //             CategoryId = p.CategoryId
            //         };
            //         p.AvailableId = availableId;
            //         p.Quantity = quantityNew;


            ViewBag.Success = "success";
            string subject = "Thank you for your order!";
            string content = @"<!DOCTYPE html>
<html>
  <head>
    <meta charset=""utf-8"" />
    <meta http-equiv=""x-ua-compatible"" content=""ie=edge"" />
    <title>Email Confirmation</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"" />
    <style type=""text/css"">
      @media screen {
        @font-face {
          font-family: ""Source Sans Pro"";
          font-style: normal;
          font-weight: 400;
          src: local(""Source Sans Pro Regular""), local(""SourceSansPro-Regular""),
            url(https://fonts.gstatic.com/s/sourcesanspro/v10/ODelI1aHBYDBqgeIAH2zlBM0YzuT7MdOe03otPbuUS0.woff)
              format(""woff"");
        }

        @font-face {
          font-family: ""Source Sans Pro"";
          font-style: normal;
          font-weight: 700;
          src: local(""Source Sans Pro Bold""), local(""SourceSansPro-Bold""),
            url(https://fonts.gstatic.com/s/sourcesanspro/v10/toadOcfmlt9b38dHJxOBGFkQc6VGVFSmCnC_l7QZG60.woff)
              format(""woff"");
        }
      }

      body,
      table,
      td,
      a {
        -ms-text-size-adjust: 100%; /* 1 */
        -webkit-text-size-adjust: 100%; /* 2 */
      }

      table,
      td {
        mso-table-rspace: 0pt;
        mso-table-lspace: 0pt;
      }

      img {
        -ms-interpolation-mode: bicubic;
      }

      a[x-apple-data-detectors] {
        font-family: inherit !important;
        font-size: inherit !important;
        font-weight: inherit !important;
        line-height: inherit !important;
        color: inherit !important;
        text-decoration: none !important;
      }

      div[style*=""margin: 16px 0;""] {
        margin: 0 !important;
      }

      body {
        width: 100% !important;
        height: 100% !important;
        padding: 0 !important;
        margin: 0 !important;
      }

      table {
        border-collapse: collapse !important;
      }

      a {
        color: #1a82e2;
      }

      img {
        height: auto;
        line-height: 100%;
        text-decoration: none;
        border: 0;
        outline: none;
      }
    </style>
  </head>
  <body style=""background-color: #e9ecef"">
    <div
      class=""preheader""
      style=""
        display: none;
        max-width: 0;
        max-height: 0;
        overflow: hidden;
        font-size: 1px;
        line-height: 1px;
        color: #fff;
        opacity: 0;
      ""
    >
      A preheader is the short summary text that follows the subject line when
      an email is viewed in the inbox.
    </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
      <tr>
        <td align=""center"" bgcolor=""#e9ecef"">
          <table
            border=""0""
            cellpadding=""0""
            cellspacing=""0""
            width=""100%""
            style=""max-width: 600px""
          >
            <tr>
              <td align=""center"" valign=""top"" style=""padding: 36px 24px""></td>
            </tr>
          </table>
        </td>
      </tr>
      <tr>
        <td align=""center"" bgcolor=""#e9ecef"">
          <table
            border=""0""
            cellpadding=""0""
            cellspacing=""0""
            width=""100%""
            style=""max-width: 600px""
          >
            <tr>
              <td
                align=""left""
                bgcolor=""#ffffff""
                style=""
                  padding: 36px 24px 0;
                  font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
                  border-top: 3px solid #d4dadf;
                ""
              >
                <h1
                  style=""
                    margin: 0;
                    font-size: 32px;
                    font-weight: 700;
                    letter-spacing: -1px;
                    line-height: 48px;
                  ""
                >
                  Thank you for your order
                </h1>
              </td>
            </tr>
          </table>
        </td>
      </tr>
      <tr>
        <td align=""center"" bgcolor=""#e9ecef"">
          <table
            border=""0""
            cellpadding=""0""
            cellspacing=""0""
            width=""100%""
            style=""max-width: 600px""
          >
            <tr>
              <td
                align=""left""
                bgcolor=""#ffffff""
                style=""
                  padding: 24px;
                  font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
                  font-size: 16px;
                  line-height: 24px;
                ""
              >
                <p style=""margin: 0"">Dear,</p>
                <p style=""margin: 0"">
                  Tap the button below to confirm your email address. If you
                  didn't create an account with , you can safely delete this
                  email.
                </p>
              </td>
            </tr>
            <tr>
              <td
                align=""left""
                bgcolor=""#ffffff""
                style=""
                  padding: 24px;
                  font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
                  font-size: 16px;
                  line-height: 24px;
                ""
              >
                <p style=""margin: 0"">
                  If that doesn't work, copy and paste the following link in
                  your browser:
                </p>
                <p style=""margin: 0"">
                  <a href=""https://localhost:5001/"" target=""_blank""
                    >Furniture Shop</a
                  >
                </p>
              </td>
            </tr>
            <tr>
              <td
                align=""left""
                bgcolor=""#ffffff""
                style=""
                  padding: 24px;
                  font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
                  font-size: 16px;
                  line-height: 24px;
                  border-bottom: 3px solid #d4dadf;
                ""
              >
                <p style=""margin: 0"">
                  Cheers,<br />
                  <br />
                  Furniture Shop
                </p>
              </td>
            </tr>
          </table>
        </td>
      </tr>
      <tr>
        <td align=""center"" bgcolor=""#e9ecef"" style=""padding: 24px"">
          <table
            border=""0""
            cellpadding=""0""
            cellspacing=""0""
            width=""100%""
            style=""max-width: 600px""
          >
            <tr>
              <td
                align=""center""
                bgcolor=""#e9ecef""
                style=""
                  padding: 12px 24px;
                  font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
                  font-size: 14px;
                  line-height: 20px;
                  color: #666;
                ""
              ></td>
            </tr>
            <tr>
              <td
                align=""center""
                bgcolor=""#e9ecef""
                style=""
                  padding: 12px 24px;
                  font-family: 'Source Sans Pro', Helvetica, Arial, sans-serif;
                  font-size: 14px;
                  line-height: 20px;
                  color: #666;
                ""
              ></td>
            </tr>
          </table>
        </td>
      </tr>
    </table>
  </body>
</html>
";
            await MailUtils.MailUtils.SendMailGoogleSmtp("shopvegetabledemo@gmail.com", email, subject, content);
            return View("Checkout");

        }

    }
}
