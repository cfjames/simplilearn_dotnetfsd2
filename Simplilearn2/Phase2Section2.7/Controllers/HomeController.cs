using Microsoft.AspNetCore.Mvc;
using Phase2Section2._7.Models;
using System.Diagnostics;

namespace Phase2Section2._7.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult ViewDataRedirect(string name, string address, string course, string year)
        {
            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["course"] = course;
            ViewData["year"] = year;

            return RedirectToAction("ViewDataSubmit");
        }

        [HttpPost]
        public ViewResult ViewDataSubmit()//string name, string address, string course, string year)
        {
            //ViewData["name"] = name;
            //ViewData["address"] = address;
            //ViewData["course"] = course;
            //ViewData["year"] = year;

            return View();
        }

        [HttpPost]
        public ViewResult ViewBagSubmit(string name, string address, string course, string year)
        {
            ViewBag.name = name;
            ViewBag.address = address;
            ViewBag.course = course;
            ViewBag.year = year;

            return View();
        }

        [HttpPost]
        public ActionResult TempDataRedirect(string name, string address, string course, string year)
        {
            TempData["name"] = name;
            TempData["address"] = address;
            TempData["course"] = course;
            TempData["year"] = year;

            return RedirectToAction("TempDataSubmit");
        }

        public ViewResult TempDataSubmit()
        {
            return View();
        }
    }
}