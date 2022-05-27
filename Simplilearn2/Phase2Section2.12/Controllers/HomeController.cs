using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Phase2Section2._12.ActionFilters;
using Phase2Section2._12.Models;
using System.Diagnostics;

namespace Phase2Section2._12.Controllers
{
    [ActionLoggingFilter]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[ActionLoggingFilter]
        [AllowAnonymous]
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

        [AllowAnonymous]
        public IActionResult Student()
        {
            return View();
        }

        public IActionResult StudentSecured()
        {
            return View();
        }
    }
}