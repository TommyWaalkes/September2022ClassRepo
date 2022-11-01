using Microsoft.AspNetCore.Mvc;
using OpenMovieAPI.Models;
using System.Diagnostics;

namespace OpenMovieAPI.Controllers
{
    public class HomeController : Controller
    {
        MovieDAL api = new MovieDAL();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Results r = api.SearchMovies("Forest+Gump");
            return View(r);
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