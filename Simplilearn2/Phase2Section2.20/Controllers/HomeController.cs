using Microsoft.AspNetCore.Mvc;
using Phase2Section2._20.Models;
using System.Diagnostics;
using System.Text;

namespace Phase2Section2._20.Controllers
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

        [HttpPost]
        public IActionResult Index(StudentModel model)
        {
            StringBuilder sb = new StringBuilder("Form data:\n");
            sb.Append($"{model.Name}, {model.Address}, {model.Course}, {model.Email}");
            return Content(sb.ToString());
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