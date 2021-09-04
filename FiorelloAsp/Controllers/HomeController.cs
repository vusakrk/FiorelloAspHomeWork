using FiorelloAsp.DAL;
using FiorelloAsp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
            
        public async Task<IActionResult> Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Slides = await _context.Slides.ToListAsync(),
                Introduction = await _context.Introductions.FirstOrDefaultAsync(),
                Categories = await _context.Categories.Where(c => c.HasDeleted == false).ToListAsync(),
                Products = await _context.Products.Include(p => p.Category).Where(p => p.HasDeleted == false).Take(8).ToListAsync(),
                About = _context.Abouts.FirstOrDefault(),
                AboutInfos = await _context.AboutInfos.ToListAsync(),
                Experts = await _context.Experts.Include(e => e.Role).ToListAsync(),
                Blogs = await _context.Blogs.ToListAsync(),
                Tastimonials = await _context.Tastimonials.ToListAsync(),
                Instagrams = await _context.Instagrams.ToListAsync(),
                instagramHashtag = await _context.InstagramHashtags.FirstOrDefaultAsync(),
                Subscribe = await _context.Subscribes.FirstOrDefaultAsync(),
                FooterSocial = await _context.FooterSocials.FirstOrDefaultAsync()
                
            };
            return View(homeViewModel);
        }
    }
}
