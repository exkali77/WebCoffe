using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Html;
using WebCoffe.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.Entity.Core.Objects;

namespace WebCoffe.Controllers
{
    public class AddCoffeController : Controller
    {
        private readonly  appDbContext _context;
        public AddCoffeController(appDbContext context)
        {
            _context = context;
        }
        public IActionResult AddCoffe()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddCoffe(IFormCollection form)
        {  
            if (ModelState.IsValid)
            {
                Product product = new Product();
              product.name = form["cname"].ToString();
                product.deskrption = form["cDecription"].ToString();
                _context.Coffe.Add(product);
                _context.SaveChanges();

            }
            else
            {
               
            }
            return View();
        }
    }
}
