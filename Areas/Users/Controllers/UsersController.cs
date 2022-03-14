using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQFurni.Models;

namespace MAQFurni.Areas_Users_Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {
        private readonly FurnitureShopContext _context;

        public UsersController(FurnitureShopContext context)
        {
            _context = context;
        }

        // GET: Users
        [HttpGet("admin/users")]
        public async Task<IActionResult> Index()
        {
            var furnitureShopContext = _context.Users.Include(u => u.UserStatus);
            return View(await furnitureShopContext.ToListAsync());
        }

        // GET: Users/Details/5
        [HttpGet("admin/users/detail/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.UserStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        [HttpGet("admin/users/create")]
        public IActionResult Create()
        {
            ViewData["UserStatusId"] = new SelectList(_context.Set<UserStatus>(), "StatusId", "StatusName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("admin/users/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CreateDate,UserStatusId,RoleId,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserStatusId"] = new SelectList(_context.Set<UserStatus>(), "StatusId", "StatusName", user.UserStatusId);
            return View(user);
        }

        // GET: Users/Edit/5
        [HttpGet("admin/users/edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["UserStatusId"] = new SelectList(_context.Set<UserStatus>(), "StatusId", "StatusName", user.UserStatusId);
            ViewBag.RoleId = new SelectList(_context.Roles, "Id", "Name", user.RoleId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("admin/users/edit/{id}"), ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string Id, int UserStatusId, int RoleId)
        {
            User user = _context.Users.SingleOrDefault(o => o.Id == Id);



            try
            {
                user.UserStatusId = UserStatusId;
                user.RoleId = RoleId;
                _context.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            ViewData["UserStatusId"] = new SelectList(_context.Set<UserStatus>(), "StatusId", "StatusName", user.UserStatusId);
            ViewBag.RoleId = new SelectList(_context.Roles, "Id", "Name", user.RoleId);
            // return RedirectToAction(nameof(Index));



            return View(user);
        }

        // GET: Users/Delete/5
        [HttpGet("admin/users/delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.UserStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost("admin/users/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = await _context.Users.FindAsync(id);
            var order = _context.Orders.Where(o => o.UserId == id);
            if (order == null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index), new { status = "fail" });
        }

        private bool UserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
