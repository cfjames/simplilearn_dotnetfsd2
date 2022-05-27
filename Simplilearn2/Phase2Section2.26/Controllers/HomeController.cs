using Microsoft.AspNetCore.Mvc;
using Phase2Section2._26.Models;
using System.Diagnostics;

namespace Phase2Section2._26.Controllers
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
            if (Request.Query["t"] == "")
                ViewData["message"] = "Please select a list type";
            else if (Request.Query["t"] == "students")
            {
                ViewData["stype"] = "students";
                ViewData["message"] = "List Of Students";
                List<String> list = new List<string>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Student " + i.ToString());
                }
                ViewData["list"] = list;
            }
            else if (Request.Query["t"] == "teachers")
            {
                ViewData["stype"] = "teachers";
                ViewData["message"] = "List Of Teachers";
                List<String> list = new List<string>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add("Teacher " + i.ToString());
                }
                ViewData["list"] = list;
            }
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