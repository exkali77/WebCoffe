using Microsoft.AspNetCore.Mvc;

namespace WebCoffe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
