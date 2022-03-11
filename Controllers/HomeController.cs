using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MAQFurni.Models;
using Microsoft.EntityFrameworkCore;

namespace MAQFurni.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly FurnitureShopContext _context;

        public HomeController(FurnitureShopContext context)
        {
            _context = context;
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

        [HttpGet]
        public IActionResult Sort(string condition, string search) 
        {
            List<Product> searchList = new List<Product>();
            if (condition.Equals("1")) {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderBy(p => p.ProductName).ToList();
            }
            else if (condition.Equals("2")) {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderByDescending(p => p.ProductName).ToList();
            }
            else if (condition.Equals("3")) {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderByDescending(p => p.ProductPrice).ToList();
            }
            else if (condition.Equals("4")) {
                searchList = _context.Products.Where(p => p.ProductName.Contains(search)).OrderBy(p => p.ProductPrice).ToList();
            }
            else {
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
