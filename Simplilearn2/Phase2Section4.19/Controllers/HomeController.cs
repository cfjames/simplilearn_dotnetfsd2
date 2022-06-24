using Microsoft.AspNetCore.Mvc;
using Phase2Section4._19.Models;
using SchoolEfDAL;
using System.Diagnostics;

namespace Phase2Section4._19.Controllers
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
            StudentListModel model = new StudentListModel();
            model.FullList = _context.Students.ToList();

            model.FirstStudent = model.FullList.OrderBy(st => st.Name).First();

            model.LastStudent = model.FullList.LastOrDefault();

            model.ThirdStudent = model.FullList.ElementAt(2);

            model.FirstWith90Percent = model.FullList.First(st => st.Grades == 90);

            List<StudentModel> emptyList = new List<StudentModel>();

            IEnumerable<StudentModel> defaultIfEmpty = emptyList.DefaultIfEmpty();

            model.EmptyList = defaultIfEmpty;

            return View(model);
        }
    }
}