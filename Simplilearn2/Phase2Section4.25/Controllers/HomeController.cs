using Microsoft.AspNetCore.Mvc;
using Phase2Section4._25.Models;
using SchoolEfDAL;
using System.Diagnostics;

namespace Phase2Section4._25.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SchoolContext _context;

        public HomeController(ILogger<HomeController> logger, SchoolContext context)
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
            StudentListModel model = new StudentListModel();
            model.FullList = _context.Students.ToList();

            var studentsGreaterThan90 = model.FullList.Where(st => st.Grades > 90);
            var studentsLessThanOrEqual90 = model.FullList.Where(st => st.Grades <= 90);

            var studentsGreaterThan80 = model.FullList.Where(st => st.Grades > 80);
            var studentsLessThanOrEqual80 = model.FullList.Where(st => st.Grades <= 80);

            model.UnionList =
                studentsGreaterThan80.Union(studentsLessThanOrEqual90).ToList();


            model.IntersectList =
                studentsGreaterThan80.Intersect(studentsLessThanOrEqual90).ToList();

            model.DistinctList = (from st in model.FullList
                                  select (dynamic)new { st.Grades }).Distinct().ToList();

            model.ExceptList = studentsGreaterThan80.Except(studentsLessThanOrEqual90).ToList();


            return View(model);

        }
    }
}