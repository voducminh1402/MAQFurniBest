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
        public IActionResult Shopping(string condition)
        {
            List<Product> listProduct = new List<Product>();

            if (condition == null) {
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
            var categoryView =_context.Categories.Select(c => new CategoryView {
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

             if (condition == null) {
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

            ProductPriceMinMax productPrice = new ProductPriceMinMax 
            {
                Min = searchList.OrderBy(p => p.ProductPrice).FirstOrDefault().ProductPrice,
                Max = searchList.OrderByDescending(p => p.ProductPrice).FirstOrDefault().ProductPrice
            };

            ViewBag.ProductList = searchList;
            ViewBag.MinMax = productPrice;
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
        public async Task<IActionResult> CheckOutAsync(string cart, string firstName, string lastName, string city, string phone, string state, string address)
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
                    Note = "",
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
            return View("Checkout");

        }
        // [HttpPost("cart/check-out")]
        // // [ActionName("AddOrder")]
        // public string CheckOut(string cart, string phone, string fullName, string city, string state, string address)
        // {
        //     var userId = _userManager.GetUserId(User);
        //     if(userId == null){ 
        //         return "not login";
        //     }
        //     if(cart.Equals("null")){
        //         return "cart null";
        //     }
        //     // cart = cart.Substring(1, cart.Length - 2);
        //     dynamic json  = JsonConvert.DeserializeObject(cart);
        //     // List<object> object = JsonConvert.DeserializeObject(json);
        //     Console.WriteLine(json);
        //     string id;
        //     decimal price;
        //     int quantity;
        //     foreach(var o in json){
        //         id = o["id"];
        //         string p = o["price"];
        //         string q = o["quantity"];
        //         price = decimal.Parse(p);
        //         quantity = int.Parse(q);
        //         Console.WriteLine($"{id} - {price} - {quantity}");
        //     }
        //     Console.WriteLine(phone, fullName, address, city, state);
        //     // Guid orderId = Guid.NewGuid();
        //     // Order order = new Order{
        //     //     OrderId = orderId.ToString(),
        //     //     CreateDate = DateTime.Now,
        //     //     UserId = userId,
        //     //     OrderDetails = null,
        //     //     ShippingInfo = null
        //     // };
        //     return "success";
        // }
    }
}
