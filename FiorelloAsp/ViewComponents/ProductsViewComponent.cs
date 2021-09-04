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
        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Product> products = _context.Products
                                                .Where(p => p.HasDeleted == false)
                                                  .Take(take).ToList();
            return View(await Task.FromResult(products));
        }
    }
}
