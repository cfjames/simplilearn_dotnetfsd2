using Microsoft.AspNetCore.Mvc;
using Phase2Section2._18.Models;
using System.Diagnostics;

namespace Phase2Section2._18.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolContext _db;

        public HomeController(ILogger<HomeController> logger, SchoolContext db)
        {
            _logger = logger;
            _db = db;
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

        public IActionResult StudentList()
        {
            List<StudentModel> model = _db.Students.ToList();
            return View(model);
        }

        public IActionResult StudentListEditRow(int id)
        {
            StudentModel model = _db.Students.Find(id);
            return PartialView("_StudentListEditRow", model);
        }

        public IActionResult StudentListDisplayRow(int id)
        {
            StudentModel model = _db.Students.Find(id);
            return PartialView("_StudentListDisplayRow", model);
        }

        public IActionResult StudentInfo1(string id, string name)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            return View();
        }
    }
}