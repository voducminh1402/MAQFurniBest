using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MAQFurni.Models;
using ProductModel = MAQFurni.Models.Product;

namespace MAQFurni.Areas.Product.Controllers
{
    [Area("Product")]
    public class ProductController : Controller
    {
        private readonly FurnitureShopContext _context;

        public ProductController(FurnitureShopContext context)
        {
            _context = context;
        }

        // GET: Product
        [HttpGet("admin/product")]
        public async Task<IActionResult> Index()
        {
            var furnitureShopContext = _context.Products.Include(p => p.Available).Include(p => p.Category);
            ViewBag.Available = new SelectList(_context.ProductAvailables, "AvailableId", "AvailableName");
            return View(await furnitureShopContext.ToListAsync());
        }
        [HttpPost("admin/product/filter-by-status")]
        [ActionName("Filter")]
        public async Task<IActionResult> Filter(int status)
        {
            var furnitureShopContext = _context.Products.Where(o => o.AvailableId == status).Include(p => p.Available).Include(p => p.Category);
            ViewBag.Available = new SelectList(_context.ProductAvailables, "AvailableId", "AvailableName");
            return View("Index", await furnitureShopContext.ToListAsync());
        }
        // GET: Product/Details/5
        [HttpGet("admin/product/detail/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Available)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        [HttpGet("admin/product/create")]
        public IActionResult Create()
        {
            ViewData["AvailableId"] = new SelectList(_context.ProductAvailables, "AvailableId", "AvailableName");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("admin/product/create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductName,ProductImage,ProductPrice,Quantity,Description,AvailableId,CategoryId")] ProductModel product)
        {
            Guid uuid = Guid.NewGuid();
            var id = uuid.ToString();
            DateTime date = DateTime.Now;
            product.CreateDate = date;
            product.ProductId = id;
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AvailableId"] = new SelectList(_context.ProductAvailables, "AvailableId", "AvailableName", product.AvailableId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Product/Edit/5
        [HttpGet("admin/product/edit/{id}")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            ViewData["AvailableId"] = new SelectList(_context.ProductAvailables, "AvailableId", "AvailableName", product.AvailableId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        [HttpGet("admin/product/search"), ActionName("Search")]
        public async Task<IActionResult> Search(string search)
        {
            search = search.Trim();
            ViewBag.Search = search;
            if (search.Length > 0)
            {
                var furnitureShopContext = _context.Products.Where(o => o.ProductName.Contains(search)).Include(p => p.Available).Include(p => p.Category);
                return View("Index", await furnitureShopContext.ToListAsync());
            }
            else
            {
                var furnitureShopContext = _context.Products.Include(p => p.Available).Include(p => p.Category);
                return View("Index", await furnitureShopContext.ToListAsync());
            }

        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("admin/product/edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string ProductId, string ProductName, string ProductImage, decimal ProductPrice, int Quantity, string Description, int AvailableId, int CategoryId)
        {
            ProductModel product = _context.Products.SingleOrDefault(o => o.ProductId == ProductId);

            if (ModelState.IsValid)
            {
                try
                {
                    product.ProductName = ProductName;
                    product.ProductImage = ProductImage;
                    product.ProductPrice = ProductPrice;
                    product.Quantity = Quantity;
                    product.AvailableId = AvailableId;
                    product.CategoryId = product.CategoryId;
                    product.Description = Description;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
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
            ViewData["AvailableId"] = new SelectList(_context.ProductAvailables, "AvailableId", "AvailableName", product.AvailableId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        // GET: Product/Delete/5
        [HttpGet("admin/product/delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Available)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost("admin/product/delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
