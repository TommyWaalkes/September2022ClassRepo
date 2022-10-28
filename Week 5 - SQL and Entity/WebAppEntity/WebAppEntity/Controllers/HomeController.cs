using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppEntity.Models;

namespace WebAppEntity.Controllers
{
    //Outside of errors, .net doesn't really print to the browser console
    public class HomeController : Controller
    {
        Movies2Context db = new Movies2Context();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Movie m = db.Movies.First();
            return View(m);
        }

        public IActionResult MovieList()
        {
            List<Movie> movies = db.Movies.ToList();
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}