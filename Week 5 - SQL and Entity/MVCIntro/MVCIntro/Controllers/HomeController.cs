using Microsoft.AspNetCore.Mvc;
using MVCIntro.Models;
using System.Diagnostics;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        //In order to make code for a view, I must do 3 things 
        //1) I must match the name and spelling of the view with my method signature 
        //2) Must have a IActionResult return type - this tell .Net to treat this method as an action 
        //You can still write regular in controllers 
        //3) you must return View or a Redirect, this tell .Net to render our view or move to another one
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult FishFacts()
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