using Microsoft.AspNetCore.Mvc;
using prjAJAXHW.Models;
using System.Diagnostics;

namespace prjAJAXHW.Controllers
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

        public IActionResult employee()
        {
            return View();
        }

        public IActionResult travelspots()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }

        public IActionResult AddressFetch()
        {
            return View();
        }

        public IActionResult Register()
        {
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