using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQFurni.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace MAQFurni.Areas_Order_Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Order")]
    public class OrderController : Controller
    {
        private readonly FurnitureShopContext _context;

        public OrderController(FurnitureShopContext context)
        {
            _context = context;
        }

        // GET: Order
        [HttpGet("admin/order")]

        public async Task<IActionResult> Index()
        {
            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
            var furnitureShopContext = _context.Orders.Include(o => o.User).Include(o => o.ShippingInfo);
            return View(await furnitureShopContext.ToListAsync());
        }

        // [HttpPost("admin/order/filter-by-status")]  
        // [ActionName("filter-by-status")]     
        // public String FilterByStatus(int status)
        // {
        //     Console.WriteLine(status);
        //     ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
        //     List<Order> list;
        //     if (status == 0){
        //         list = _context.Orders.Include(o => o.User).Include(o => o.ShippingInfo).ToList();

        //     return json;
        // }


        [HttpPost("admin/order/filter-by-status")]
        [ActionName("Filter")]
        public async Task<IActionResult> Filter(int status)
        {
            var furnitureShopContext = _context.Orders.Where(o => o.ShippingInfo.StatusId == status).Include(o => o.User).Include(o => o.ShippingInfo);
            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
            return View("Index", await furnitureShopContext.ToListAsync());
        }


        // public List<Order> FilterByStatus(int status)
        // {

        //     ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
        //     if (search.Trim().Length == 0)
        //     {
        //         var furnitureShopContext1 = _context.Orders.Include(o => o.User);
        //         return View(await furnitureShopContext1.ToListAsync());
        //     }
        //     var furnitureShopContext = _context.Orders.Where(o => o.User.UserName.Contains(search)).Include(o => o.User).Include(o => o.ShippingInfo);
        //     ViewBag.SearchString = search;
        //     return View("Index", await furnitureShopContext.ToListAsync());

        //     ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
        //     List<Order> list;

        //     if (status == 0)
        //     {
        //         list = _context.Orders.ToList();

        //     }
        //     else
        //     {
        //         list = _context.Orders.Where(o => o.ShippingInfo.StatusId == status).ToList();
        //     }
        //     return list;
        // }


        [HttpGet("admin/order/find")]
        [ActionName("find")]
        public async Task<IActionResult> SearchAsync(string search)
        {
            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
            if (search.Trim().Length == 0)
            {
                var furnitureShopContext1 = _context.Orders.Include(o => o.User);
                return View(await furnitureShopContext1.ToListAsync());
            }
            var furnitureShopContext = _context.Orders.Where(o => o.User.UserName.Contains(search)).Include(o => o.User).Include(o => o.ShippingInfo);
            ViewBag.SearchString = search;
            return View("Index", await furnitureShopContext.ToListAsync());
        }

        [HttpPost("admin/order/change-status")]
        [ActionName("ChangeStatus")]
        public async Task<IActionResult> ChangeStatus(string status, string id)
        {
            var order = _context.ShippingInfos.SingleOrDefault(o => o.OrderId == id);
            order.StatusId = int.Parse(status);
            _context.ShippingInfos.Update(order);
            await _context.SaveChangesAsync();
            var orders = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.ShippingInfo)
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(m => m.OrderId == id);

            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName", orders.ShippingInfo.StatusId);

            ViewBag.Product = _context.OrderDetails.Where(o => o.OrderId == id).Include(o => o.Product);

            return View("Details", orders);
        }

        // GET: Order/Details/5
        [HttpGet("admin/order/detail/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.ShippingInfo)
                .Include(o => o.OrderDetails)
                .FirstOrDefaultAsync(m => m.OrderId == id);

            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName", order.ShippingInfo.StatusId);

            ViewBag.Product = _context.OrderDetails.Where(o => o.OrderId == id).Include(o => o.Product);


            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
    }
}
