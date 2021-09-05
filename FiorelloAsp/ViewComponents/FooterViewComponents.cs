using FiorelloAsp.DAL;
using FiorelloAsp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloAsp.ViewComponents
{
    public class FooterViewComponents:ViewComponent
    {
        public AppDbContext _context { get; }
        public FooterViewComponents(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterSocial model = _context.FooterSocials.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
