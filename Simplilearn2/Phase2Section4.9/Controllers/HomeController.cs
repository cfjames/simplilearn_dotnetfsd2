using Microsoft.AspNetCore.Mvc;
using Phase2Section4._9.Models;
using SchoolEfDAL;
using System.Diagnostics;

namespace Phase2Section4._9.Controllers
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
            List<StudentModel> students = _context.Students.ToList();
            ViewData["students"] = students;

            var filter = (from st in students
                          where st.Grades > 80
                          select st).ToList();
            //var filter = students.Select(st => st.Grades > 80).ToList();    
            ViewData["filter"] = filter;

            foreach (StudentModel st in students)
            {
                st.Subjects = new List<string>();
                for(int i=0;i<4;i++)
                { 
                    st.Subjects.Add("Subject" + (i+1).ToString());
                }
            }

            var subjectMasterList = students.SelectMany
                (st => st.Subjects).ToList();
            ViewData["masterSubjectList"] = subjectMasterList;

            return View();
        }

        public IActionResult StudentListUsingModel()
        {
            StudentListModel model = new StudentListModel();
            model.Students = _context.Students.ToList();

            var filter = (from st in model.Students
                          where st.Grades > 80
                          select st).ToList();
            //var filter = students.Select(st => st.Grades > 80).ToList();    
            model.StudentsFiltered = filter;

            foreach (StudentModel st in model.Students)
            {
                st.Subjects = new List<string>();
                for (int i = 0; i < 4; i++)
                {
                    st.Subjects.Add("Subject" + (i + 1).ToString());
                }
            }

            var subjectMasterList = model.Students.SelectMany
                (st => st.Subjects).ToList();
            model.Subjects = subjectMasterList;

            return View(model);
        }
    }
}