using FiorelloAsp.DAL;
using FiorelloAsp.Models;
using FiorelloAsp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public AppDbContext _context { get; }
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (Request.Cookies["basket"] != null)
            {
                List<BasketViewModel> products = JsonConvert.DeserializeObject<List<BasketViewModel>>(Request.Cookies["basket"]);
                
            }
            

            FooterSocial model = _context.FooterSocials.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
        }
}
