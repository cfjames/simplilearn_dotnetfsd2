using Microsoft.AspNetCore.Mvc;
using Phase2Section4._15.Models;
using SchoolEfDAL;
using System.Diagnostics;

namespace Phase2Section4._15.Controllers
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
            model.TakeList = model.FullList.Take(3).ToList();
            model.TakeWhileList = model.FullList.
                TakeWhile(st => st.Grades < 95).ToList();
            model.SkipList = _context.Students.Skip(3).ToList();
            model.SkipWhileList = model.FullList.
                SkipWhile(st => st.Grades < 95).ToList();


            return View(model);
        }

        public IActionResult StudentListPaged()
        {
            ViewBag.PageNumber = 1;
            StudentListModel model = new StudentListModel();
            model.FullList = _context.Students.Take(2).ToList();
            return View(model);
        }

        public IActionResult StudentListNext(int page)
        {
            int pageSize = 2;
            page++;
            ViewBag.PageNumber = page;
            StudentListModel model = new StudentListModel();
            model.FullList = _context.Students.
                Skip((page-1)* pageSize).Take(pageSize).ToList();
            return View("StudentListPaged",model);
        }

        public IActionResult StudentListPrev(int page)
        {
            int pageSize = 2;
            page--;
            ViewBag.PageNumber = page;
            StudentListModel model = new StudentListModel();
            model.FullList = _context.Students.
                Skip((page - 1) * pageSize).Take(pageSize).ToList();
            return View("StudentListPaged", model);
        }
    }
}