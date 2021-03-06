using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQFurni.Models;
using Microsoft.AspNetCore.Authorization;

namespace MAQFurni.Areas_Category_Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Category")]
    public class CategoryController : Controller
    {
        private readonly FurnitureShopContext _context;

        public CategoryController(FurnitureShopContext context)
        {
            _context = context;
        }

        // GET: Category
        [HttpGet("/admin/category")]
        public async Task<IActionResult> Index()
        {
            CategoryList ctl = new CategoryList();
            ctl.ListCategory =await _context.Categories.ToListAsync();
            ctl.Category = new Category();
            return View(ctl);
        }

        // GET: Category/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: Category/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/admin/category/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryName,CategoryImage")] Category category)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(category);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            else {
                CategoryList ctl = new CategoryList();
                ctl.ListCategory =await _context.Categories.ToListAsync();
                ctl.Category = new Category();
                return View("Index", ctl);
            } 
        }

        // GET: Category/Edit/5
        [HttpGet("/admin/category/edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("/admin/category/edit/{id}"), ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName,CategoryImage")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CategoryId))
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
            return View(category);
        }

        // GET: Category/Delete/5
        [HttpGet("/admin/category/delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost("/admin/category/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool flag = false;

            List<Product> productList = await _context.Products.Where(p => p.CategoryId == id).ToListAsync();

            foreach (var product in productList)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                flag = true;
            }

            if (flag) {
                var category = await _context.Categories.FindAsync(id);
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
