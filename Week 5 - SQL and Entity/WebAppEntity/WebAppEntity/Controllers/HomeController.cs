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

        public IActionResult Search()
        {
            //This displays the view 
            return View();
        }

        public IActionResult SearchById()
        {
            List<Movie> movies = db.Movies.ToList();
            return View(movies);
        }

        public IActionResult IdResult(int id)
        {
            //Find takes an Primary key and returns the matching if one is present 
            //This come from entity
            Movie result = db.Movies.Find(id);

            return View(result);
        }

        //You can pass along full objects into actions and you may do single pieces of data as well 
        //As long as the parameter in the action matches up with the names of the inputs
        public IActionResult SearchResult(string Title) 
        { 
            List<Movie> results = db.Movies.Where(x => x.Title.Contains(Title) ).ToList();
            return View(results);
        }

        //This action handles display the AddMovie view and nothing else
        public IActionResult AddMovie()
        {
            return View();
        }

        //This action handles the adding of the movie into our database
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            db.Movies.Add(movie);
            //Any time you make changes to your db you must save them or they will disappear 
            db.SaveChanges();

            //A redirectToAction Invoke another action is .net's preferred of way of doing redirects
            //There a number of useful overloads, 1 in particular is where it takes in 2 strings:
            //one for the action and one for the controller 
            //  return RedirectToAction("MovieList");
            return MovieList();
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