using FiorelloAsp.DAL;
using FiorelloAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        public AppDbContext _context { get; }
        public ProductsViewComponent(AppDbContext context)
        {
            _context = context;
        }
        //public async Task<IViewComponentResult> InvokeAsync(int count=12)
        //{
        //    var model =  _context.Products.Include(p => p.Category)
        //             .Where(p => p.HasDeleted == false).OrderByDescending(p => p.Id).Take(count);
                    
        //    return View(await Task.FromResult(model));
        //}
        public async Task<IViewComponentResult> InvokeAsync(int count=12)
        {
            IEnumerable<Product> model = _context.Products.Include(p => p.Category).Take(count);
            return View(await Task.FromResult(model));
        }
    }
}
