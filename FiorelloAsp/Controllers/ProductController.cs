using FiorelloAsp.DAL;
using FiorelloAsp.Models;
using FiorelloAsp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Categories = await _context.Categories.Where(c => c.HasDeleted == false).ToListAsync(),
                Products = await _context.Products.Include(p => p.Category).Where(p => p.HasDeleted == false).Take(8).ToListAsync(),

            };
            return View(homeViewModel);
        }
        public async Task <IActionResult> LoadMore(int take=8,int skip = 12)
        {
            var model = await _context.Products.Include(p=>p.Image).Where(p=>p.HasDeleted==false)
                            .OrderByDescending(p=>p.Id).Skip(skip).Take(take).ToListAsync();
            return PartialView("_productPartial", model);
        }
    }

}
