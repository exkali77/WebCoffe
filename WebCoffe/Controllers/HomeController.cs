using Microsoft.AspNetCore.Mvc;
using WebCoffe.Models;

namespace WebCoffe.Controllers
{
    public class HomeController : Controller
    {
       // private appDbContext _context;
        public IActionResult Home()
        {
           
            return View();
        }
    }
}
