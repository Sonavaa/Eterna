using Eterna.DataAccessLayer;
using Eterna.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eterna.Controllers
{
    public class AboutController : Controller
    {
        private AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          List<About> Abouts=_context.Abouts.ToList(); 
            return View(Abouts);
        }
    }
}
