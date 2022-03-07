using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQFurni.Models;
using Newtonsoft.Json;

namespace MAQFurni.Areas_Order_Controllers
{
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
            var furnitureShopContext = _context.Orders.Include(o => o.User);
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
                
        //     }
        //     else {
        //         list = _context.Orders.Where(o => o.ShippingInfo.StatusId == status).Include(o => o.User).Include(o => o.ShippingInfo).ToList();
        //     }
        //     var json = JsonConvert.SerializeObject(list);
            
        //     return json;
        // }
        

        [HttpPost("admin/order/filter-by-status")]  
        [ActionName("filter-by-status")]     
        public List<Order> FilterByStatus(int status)
        {
            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
            List<Order> list;
            if (status == 0){
                list = _context.Orders.ToList();
                
            }
            else {
                list = _context.Orders.Where(o => o.ShippingInfo.StatusId == status).ToList();
            }
            return list;
        }

        [HttpGet("admin/order/find")]  
        [ActionName("find")]     
        public async Task<IActionResult> SearchAsync(string search)
        {
            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");
            if (search.Trim().Length == 0){
                var furnitureShopContext1 = _context.Orders.Include(o => o.User);
                return View(await furnitureShopContext1.ToListAsync());
            }
            var furnitureShopContext = _context.Orders.Where(o => o.User.UserName.Contains(search)).Include(o => o.User);
            ViewBag.SearchString = search;
            return View("Index", await furnitureShopContext.ToListAsync());
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
                .FirstOrDefaultAsync(m => m.OrderId == id);

            ViewBag.OrderStatus = new SelectList(_context.ShippingStatuses, "StatusId", "StatusName");

            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        

        // GET: Order/Create
        [HttpGet("admin/order/create")]
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName");
            return View();
        }

        // POST: Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("admin/order/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderId,UserId,TotalPrice,CreateDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            return View(order);
        }

        // GET: Order/Edit/5
        [HttpGet("admin/order/edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "UserName", order.UserId);
            return View(order);
        }

        // POST: Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("admin/order/edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("OrderId,UserId,TotalPrice,CreateDate")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", order.UserId);
            return View(order);
        }

        // GET: Order/Delete/5
        [HttpGet("admin/order/delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost("admin/order/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(string id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
