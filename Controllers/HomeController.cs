using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using P_0009_PassData_View_Controller_Using_RequestObject.Models;

namespace P_0009_PassData_View_Controller_Using_RequestObject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RegistrationForm()
        {
            ViewBag.username = Request.Form["username"];
            ViewBag.email = Request.Form["email"];
            ViewBag.gender = Request.Form["gender"];
            ViewBag.age = Request.Form["age"];
            return View();
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
