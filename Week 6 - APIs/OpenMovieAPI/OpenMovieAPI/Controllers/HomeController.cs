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
            Results r = api.SearchMovies("Forrest Gump");
            return View(r);
        }

        public IActionResult SearchByTitle()
        {
            return View();
        }

        public IActionResult Results(string title)
        {
            Results r = api.SearchMovies(title);
            return View(r);
        }

        public IActionResult MovieDetails(string id)
        {
            Movie movie = api.GetMovieById(id);
            return View(movie);
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