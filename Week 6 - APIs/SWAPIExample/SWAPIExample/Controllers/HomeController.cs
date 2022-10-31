using Microsoft.AspNetCore.Mvc;
using SWAPIExample.Models;
using System.Diagnostics;

namespace SWAPIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        SWAPIDAL api = new SWAPIDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LookUpPerson(int id)
        {
            SWPerson sp = api.GetPerson(id);
            PlanetPersonViewModel p = new PlanetPersonViewModel();
            p.Person = sp;

            //We want to figure out the id for the person's homeworld and use that to look up their homeworld
            string[] homeURL = sp.homeworld.Split("/");

            //The id should always be in the same index from that split
            int planetId = int.Parse(homeURL[5]);
            p.World = api.GetPlanet(planetId);
            p.PlanetId = planetId;
            return View(p);
        }

        public IActionResult LookUpPlanet(int id)
        {
            Planet p = api.GetPlanet(id);
            return View(p);
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