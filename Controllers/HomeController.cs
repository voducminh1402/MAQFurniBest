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
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using Microsoft.AspNetCore.Authorization;

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

        
        [Authorize(Roles = "User")]
        [AllowAnonymous]
        [ActionName("Index")]
        public async Task<IActionResult> IndexAsync()
        {
          IndexViewModel ivm = new IndexViewModel();
          ivm.ListCategory = await _context.Categories.ToListAsync();
          ivm.ListProduct = await _context.Products.ToListAsync();
          return View(ivm);
        }

        [Authorize(Roles = "User")]
        [AllowAnonymous]
        public IActionResult Search(string search)
        {
            List<Product> searchList = new List<Product>();
            searchList = _context.Products.Where(p => p.ProductName.Contains(search)).ToList();

            ViewBag.ProductList = searchList;
            ViewBag.Search = search;
            ViewBag.Cond = "Relevance";

            return View("SearchProduct");
        }

        [Authorize(Roles = "User")]
        [AllowAnonymous]
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

        [Authorize(Roles = "User")]
        [AllowAnonymous]
        public IActionResult FilterCategory(int categoryId, int? page, string condition)
        {
            List<Product> list = _context.Products.Where(p => p.CategoryId == categoryId).ToList();

            int cate = categoryId;

            int pageCurrent = (int)(page == null ? 1 : page);

            int pageSize = 9;

            if (condition == null)
            {
                condition = "Relevance";
            }

            if (condition.Equals("1"))
            {
                list = _context.Products.Where(p => p.CategoryId == categoryId).OrderBy(p => p.ProductName).ToList();
            }
            else if (condition.Equals("2"))
            {
                list = _context.Products.Where(p => p.CategoryId == categoryId).OrderByDescending(p => p.ProductName).ToList();
            }
            else if (condition.Equals("3"))
            {
                list = _context.Products.Where(p => p.CategoryId == categoryId).OrderBy(p => p.ProductPrice).ToList();
            }
            else if (condition.Equals("4"))
            {
                list = _context.Products.Where(p => p.CategoryId == categoryId).OrderByDescending(p => p.ProductPrice).ToList();
            }
            else
            {
                list = _context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }

            ViewBag.productList = list.Skip(pageSize * (pageCurrent - 1)).Take(pageSize);
            decimal countPage = new decimal(list.Count() / pageSize);
            ViewBag.CountPage = Math.Ceiling(countPage) + 1; //tim cho nay
            ViewBag.Page = pageCurrent; //tim cho nay
            ViewBag.CategoryId = categoryId;
            ViewBag.Cond = condition;

            return View("FilterCategory");
        }

        [Authorize(Roles = "User")]
        [AllowAnonymous]
        [HttpGet]
        [ActionName("Shopping")]
        public IActionResult Shopping(string condition, int? page)
        {
            List<Product> listProduct = new List<Product>();

            int pageCurrent = (int)(page == null ? 1 : page);

            int pageSize = 9;

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
                listProduct = _context.Products.OrderBy(p => p.ProductPrice).ToList();
            }
            else if (condition.Equals("4"))
            {
                listProduct = _context.Products.OrderByDescending(p => p.ProductPrice).ToList();
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

            ViewBag.ProductList = listProduct.Skip(pageSize * (pageCurrent - 1)).Take(pageSize);
            ViewBag.CategoryView = categoryView;
            decimal countPage = new decimal(listProduct.Count() / pageSize);
            ViewBag.CountPage = Math.Ceiling(countPage) + 1; //tim cho nay
            ViewBag.Page = pageCurrent; //tim cho nay
            ViewBag.Cond = condition;

            return View("Shopping");
        }

        [Authorize(Roles = "User")]
        [AllowAnonymous]
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

        [Authorize(Roles = "User")]
        [AllowAnonymous]
        [HttpGet("/view-order")]
        public IActionResult ViewOrder()
        {
            ViewBag.Order = null;
            ViewBag.ShippingInfo = null;
            ViewBag.Status = "";

            return View();
        }

        [Authorize(Roles = "User")]
        [HttpGet("order-history"), ActionName("OrderHistory")]
        public IActionResult OrderHistory()
        {
            var userId = _userManager.GetUserId(User);
            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
            var orders = _context.Orders.Where(o => o.UserId.Equals(userId)).Include(o => o.ShippingInfo.Status);
            ViewBag.Order = orders;
            return View();
        }
        [Authorize(Roles = "User")]
        [HttpGet("order-detail"), ActionName("OrderDetail")]
        public IActionResult OrderDetail(string id)
        {
            var orderDetails = _context.OrderDetails.Where(o => o.OrderId == id).Include(o => o.Product);
            ViewBag.OrderDetails = orderDetails;
            ViewBag.OrderId = id;
            return View();
        }


        [HttpPost("/view-order")]
        public IActionResult CheckOrder(string orderId, string phone)
        {
            var order = new Order();
            var shipping = new ShippingInfo();
            string status = "";

            var orderCheck = _context.Orders.Where(o => o.OrderId.Equals(orderId)).Where(o => o.ShippingInfo.Phone.Equals(phone)).FirstOrDefault();
            if (orderCheck != null)
            {
                order = orderCheck;
                shipping = _context.ShippingInfos.Where(s => s.OrderId.Equals(orderCheck.OrderId)).FirstOrDefault();
            }
            else
            {
                order = null;
                shipping = null;
                status = "Incorrect order ID or phone number! Please try again!";
            }

            ViewBag.Order = order;
            ViewBag.ShippingInfo = shipping;
            ViewBag.Status = status;
            ViewBag.OrderId = orderId;
            ViewBag.Phone = phone;
            return View("ViewOrder");
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        [Authorize(Roles = "User")]
        [HttpGet("check-out")]
        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        [HttpGet("check-out-success")]
        public IActionResult CheckoutSuccess()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("/admin/dashboard")]
        public IActionResult AdminDashboard()
        {
            int listUser = _context.Users.ToList().Count();
            int listUserBuy = _context.Orders.Select(o => o.UserId).Distinct().ToList().Count();

            int listOrders = _context.Orders.ToList().Count();
            int listOrderSuccess = _context.ShippingInfos.Where(s => s.StatusId == 1).ToList().Count();

            int listProduct = _context.Products.ToList().Count();
            int listProductBuy = _context.OrderDetails.Select(o => o.ProductId).Distinct().ToList().Count();

            List<OrderDetail> listOdDetail = _context.OrderDetails.Take(15).ToList();
            List<Order> listTransaction = _context.Orders.Take(20).ToList();

            decimal totalMoney = _context.Orders.ToList().Sum(o => o.TotalPrice);

            ViewBag.ListUser = listUser;
            ViewBag.ListUserBuy = listUserBuy;
            ViewBag.ListOrders = listOrders;
            ViewBag.ListOrderSuccess = listOrderSuccess;
            ViewBag.ListProduct = listProduct;
            ViewBag.ListProductBuy = listProductBuy;
            ViewBag.TotalMoney = totalMoney;
            ViewBag.ListOdDetail = listOdDetail;
            ViewBag.ListTransaction = listTransaction;

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


        //  [ActionName("ViewOrder")]
        // public async Task<IActionResult> ViewOrderAsync(string orderId){
        //     if(orderId == null){
        //         return NotFound();
        //     }



        //     return View("ViewOrder");

        // }


        [Authorize(Roles = "User")]
        [AllowAnonymous]
        [HttpPost("cart/check-out")]
        [ActionName("AddOrder")]
        public async Task<IActionResult> CheckOutAsync(string cart, string firstName, string lastName, string city, string phone, string state, string address, string message, string email)
        {
            var userId = _userManager.GetUserId(User);
            if (!_signInManager.IsSignedIn(User))
                return Redirect("https://localhost:5001/login");
            if (cart.Length < 2)
                return View("Checkout");
            if (cart.Length > 2)
            {
                dynamic json = JsonConvert.DeserializeObject(cart);
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
                <p style=""margin: 0"">Dear,</p><br>
                <p style=""margin: 0"">
                  We are lucky to have such great customers like you! We appreciate your order, and hope that you love it. We couldn’t do it without you. 
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
                  Cheers,
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



            return View("Checkout");

        }

    }
}
