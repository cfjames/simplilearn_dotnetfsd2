using Microsoft.AspNetCore.Mvc;
using Phase2Section4._5.Models;
using System.Diagnostics;

namespace Phase2Section4._5.Controllers
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
            Student[] arr; //= new Student[10];
            object[] arrObject = new object[11];
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student();
                student.ID = i + 1;
                student.Name = "Name " + i.ToString();
                student.Address = "Address " + i.ToString();
                student.Email = "Email " + i.ToString();
                student.Course = "Course " + i.ToString();
                arrObject[i] = student;
            }
            arrObject[10] = 19;
            arr = arrObject.OfType<Student>().ToArray();

            ViewData["students"] = arr;

            Student[] arr2 = arr.Where(s => s.ID == 2 || s.ID == 4).ToArray();
            ViewData["idfilter"] = arr2;

            Student[] arr3 = 
                arr.Where(s => s.Email == "Email 3" //&& s.Name.StartsWith("Names")
                                                    ).ToArray();
            ViewData["emailfilter"] = arr3;

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