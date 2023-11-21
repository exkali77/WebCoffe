using Microsoft.AspNetCore.Mvc;

namespace WebCoffe.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
