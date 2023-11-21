using Microsoft.AspNetCore.Mvc;

namespace WebCoffe.Controllers
{
    public class AddCoffeController : Controller
    {
        public IActionResult AddCoffe()
        {
            return View();
        }
    }
}
