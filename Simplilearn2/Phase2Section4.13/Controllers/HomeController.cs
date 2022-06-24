using Microsoft.AspNetCore.Mvc;
using Phase2Section4._13.Models;
using SchoolEfDAL;
using System.Diagnostics;

namespace Phase2Section4._13.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolContext _context;

        public HomeController(ILogger<HomeController> logger,
            SchoolContext context)
        {
            _logger = logger;
            _context = context;
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
            ViewBag.SortType = "Db Order";
            List<StudentModel> model = _context.Students.ToList();

            return View(model);
        }

        public IActionResult StudentListNA()
        {
            ViewBag.SortType = "Name Asc";
            var model = (from st in _context.Students
                           orderby st.Name
                           select st).ToList();

            return View("StudentList", model);
        }

        public IActionResult StudentListND()
        {
            ViewBag.SortType = "Name Desc";
            var model = (from st in _context.Students
                         orderby st.Name descending
                         select st).ToList();

            return View("StudentList", model);
        }

        public IActionResult StudentListGNA()
        {
            ViewBag.SortType = "Grade/Name Asc";
            var model = (from st in _context.Students
                         orderby st.Grades, st.Name
                         select st).ToList();

            return View("StudentList", model);
        }

        public IActionResult StudentListGND()
        {
            ViewBag.SortType = "Grade/Name Desc";
            var model = _context.Students.
                OrderByDescending(st => st.Grades).
                ThenByDescending(st => st.Name).ToList();

            return View("StudentList", model);
        }

        public IActionResult StudentListGAND()
        {
            ViewBag.SortType = "GradeAsc/Name Desc";
            var model = _context.Students.
                OrderBy(st => st.Grades).
                ThenByDescending(st => st.Name).ToList();

            return View("StudentList", model);
        }

        public IActionResult StudentListNR()
        {
            ViewBag.SortType = "Name Rev";
            var model = _context.Students.
                OrderBy(st => st.Name).
                Reverse().ToList();

            return View("StudentList", model);
        }
    }
}