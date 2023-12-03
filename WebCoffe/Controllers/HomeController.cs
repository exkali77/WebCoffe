using Microsoft.AspNetCore.Mvc;
using WebCoffe.Models;

namespace WebCoffe.Controllers
{
    public class HomeController : Controller
    {
        private readonly appDbContext _context;
        public HomeController(appDbContext context) 
        {
            _context = context;        
        }
        [HttpGet]
        public IActionResult Home()
        {
          var  data = _context.Coffe.ToList();
            return View(data);
        }
        [HttpPost]
        public IActionResult Home(Product product)
        {
            var valu = HttpContext.Request.Form["Coffename"];   
            return View();

        }
    }
}
