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
