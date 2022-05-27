using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Phase2Section2._14.Models;
using System.Diagnostics;
using System.Text;

namespace Phase2Section2._14.Controllers
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

        public IActionResult FormAction(StudentModel model)
        {
            if (ModelState.IsValid)
                return Content("Form is Valid");
            else
            {
                //StringBuilder sb = new StringBuilder();
                //foreach (ModelStateEntry value in ViewData.ModelState.Values)
                //{
                //    if (value.Errors.Count > 0)
                //    { 
                //        for(int i = 0; i < value.Errors.Count; i++)
                //            sb.Append(value.Errors[i].ErrorMessage + "/n");
                //    }
                //}

                //return Content
                //    ($"Form Data is invalid with {ModelState.ErrorCount} errors:\n {sb}");

                return View("Index", model);
            }
        }
    }
}