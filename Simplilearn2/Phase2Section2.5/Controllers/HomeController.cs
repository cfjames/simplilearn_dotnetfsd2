using Microsoft.AspNetCore.Mvc;
using Phase2Section2._5.Models;
using System.Diagnostics;

namespace Phase2Section2._5.Controllers
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

        public ContentResult StudentAsString()
        {
            return Content("The name of the student is Walter Smith and he is in Grade 7.");
        }

        public ViewResult StudentAsView()
        {
            ViewData["message"] = "The name of the student is <b>Walter Smith</b> and he is in Grade 7.";
            return View();
        }

        public RedirectResult StudentAsRedirectResult()
        {
            return new RedirectResult("https://www.bing.com/search?q=walter+smith");
        }

        public RedirectToRouteResult StudentAsRedirectToRouteResult()
        {
            //return RedirectToAction("StudentAsView");
            return new RedirectToRouteResult(new { Controller = "Home", action = "StudentAsView" });
        }

        public FileResult StudentAsFileResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"./wwwroot/StudentData.txt");
            string fileName = "StudentData.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        public ContentResult StudentAsJSONResult()
        {
            String data = System.IO.File.ReadAllText(@"./wwwroot/StudentData.json");
            return Content(data, "application/json");
        }

        public ViewResult StudentList()
        {
            return View("StudentAsList");
        }
    }
}