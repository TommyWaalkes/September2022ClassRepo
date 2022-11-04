using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;

namespace MVCIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            Product p = new Product();

            p.Name = "Josh";
            return View(p);
        }
    }
}
