using Microsoft.AspNetCore.Mvc;
using Phase2Section4._7.Models;
using StudentAdoDAL;
using System.Diagnostics;

namespace Phase2Section4._7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
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
            StudentDAL dal =
                new StudentDAL(_configuration.GetConnectionString("SchoolConnection"));
            List<Student> students = (List<Student>)dal.GetAllStudents();
            ViewData["students"] = students;

            var minGrade = (from st in students
                            select st.Grades).Min();
            ViewData["minGrade"] = minGrade;

            var maxGrade = students.Max(st => st.Grades);
            ViewData["maxGrade"] = maxGrade;

            var sumGrade = (from st in students
                            select st.Grades).Sum();
            ViewData["sumGrades"] = sumGrade;

            var countGrade = students.Count();
            ViewData["countGrade"] = countGrade;

            var avgGrade = students.Average(st => st.Grades);
            ViewData["avgGrade"] = avgGrade;

            return View();
        }
    }
}