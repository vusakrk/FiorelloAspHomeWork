using FiorelloAsp.DAL;
using FiorelloAsp.Models;
using FiorelloAsp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.Controllers
{

    public class ProductController : Controller
    {
        public AppDbContext _context { get; }
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            ViewBag.productCount = _context.Products.Where(p => p.HasDeleted == false)
                .Count();
            return View();
            //HomeViewModel homeViewModel = new HomeViewModel
            //{
            //    Categories = await _context.Categories.Where(c => c.HasDeleted == false).ToListAsync(),
            //    Products = await _context.Products.Include(p => p.Category).Where(p => p.HasDeleted == false).OrderByDescending(p=>p.Id).Take(8).ToListAsync(),

            //};
            //return View(homeViewModel);
        }
        public async Task <IActionResult> LoadMore(int take=12,int skip=8)
        {
            if(skip>=_context.Products.Count())
            {
                return Content("");
            }
            //var model = await _context.Products.Include(p => p.Category)
            //                .Where(p => p.HasDeleted == false).OrderByDescending(p => p.Id)
            //                .Skip(skip).Take(take).ToListAsync();
            //return PartialView("_productPartial", model);
            IEnumerable<Product> model = _context.Products.Include(p => p.Category).Skip(skip)
                .Take(8);
            return PartialView("_productPartial", model);
        }
    }

}
