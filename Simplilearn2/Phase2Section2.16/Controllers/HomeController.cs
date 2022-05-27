using Microsoft.AspNetCore.Mvc;
using Phase2Section2._16.Models;
using System.Diagnostics;

namespace Phase2Section2._16.Controllers
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

        public IActionResult StudentGet(StudentModel model)
        {
            ViewData["Mode"] = "Get";
            return View("Student", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StudentPost(StudentModel model)
        {
            ViewData["Mode"] = "Post";
            return View("Student", model);
        }
    }
}