using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserContext pc;

        public HomeController(UserContext context)
        {
            this.pc = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.info = User.Identity.Name;
            return View(await pc.Products.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            pc.Products.Add(product);
            await pc.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
       
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Product product = await pc.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                    return View(product);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Product product = await pc.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                    return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            pc.Products.Update(product);
            await pc.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Product product = await pc.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                    return View(product);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Product product = await pc.Products.FirstOrDefaultAsync(p => p.Id == id);
                if (product != null)
                {
                    pc.Products.Remove(product);
                    await pc.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
        public async Task<IActionResult> Sorted(SortState sortOrder = SortState.NameAsc)
        {
            IQueryable<Product> products = pc.Products.Include(x => x.User);

            ViewData["NameSort"] = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            ViewData["DescriptionSort"] = sortOrder == SortState.DescriptionAsc ? SortState.DescriptionDesc : SortState.DescriptionAsc;
            ViewData["PriceSort"] = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;
            ViewData["RatingSort"] = sortOrder == SortState.RatingAsc ? SortState.RatingDesc : SortState.RatingAsc;

            switch (sortOrder)
            {
                case SortState.NameDesc:
                    products = products.OrderByDescending(s => s.Name);
                    break;
                case SortState.DescriptionAsc:
                    products = products.OrderBy(s => s.Description);
                    break;
                case SortState.DescriptionDesc:
                    products = products.OrderByDescending(s => s.Description);
                    break;
                case SortState.PriceAsc:
                    products = products.OrderBy(s => s.Price);
                    break;
                case SortState.PriceDesc:
                    products = products.OrderByDescending(s => s.Price);
                    break;
                case SortState.RatingAsc:
                    products = products.OrderBy(s => s.Rating);
                    break;
                case SortState.RatingDesc:
                    products = products.OrderByDescending(s => s.Rating);
                    break;
                default:
                    products = products.OrderBy(s => s.Name);
                    break;
            }
            return View(await products.AsNoTracking().ToListAsync());
        }
        [Authorize]
        public IActionResult MyPage()
        {
            ViewBag.info = User.Identity.Name;
            return View();
        }
        
        [HttpGet]
        public IActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public string Buy()
        {     
            return "Спасибо, " + User.Identity.Name + ", за покупку!";
        }
    }
}
