using Microsoft.AspNetCore.Mvc;
using Phase2Section2._9.Models;
using System.Diagnostics;

namespace Phase2Section2._9.Controllers
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

        //public ActionResult FormGet()
        //{
        //    ViewData["name"] = Request.Query["name"];
        //    ViewData["email"] = Request.Query["email"];
        //    ViewData["course"] = Request.Query["course"];
        //    ViewData["address"] = Request.Query["address"];
        //    ViewData["Title"] = "Form Get";
        //    ViewData["Method"] = "Get";
        //    return View("Student");
        //}

        public ActionResult FormGet(string name, string email, string course, string address)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["course"] = course;
            ViewData["address"] = address;
            ViewData["Title"] = "Form Get";
            ViewData["Method"] = "Get";
            return View("Student");
        }

        //[HttpPost]
        //public ActionResult FormPost()
        //{
        //    ViewData["name"] = Request.Form["name"];
        //    ViewData["email"] = Request.Form["email"];
        //    ViewData["course"] = Request.Form["course"];
        //    ViewData["address"] = Request.Form["address"];
        //    ViewData["Title"] = "Form Post";
        //    ViewData["Method"] = "Post";
        //    string temp = Request.Query["temp"];
        //    return View("Student");
        //}

        [HttpPost]
        public ActionResult FormPost(string name, string address, string email, string course, string temp)
        {
            ViewData["name"] = name;
            ViewData["email"] = email;
            ViewData["course"] = course;
            ViewData["address"] = address;
            ViewData["Title"] = "Form Post";
            ViewData["Method"] = "Post";
            return View("Student");
        }
    }
}