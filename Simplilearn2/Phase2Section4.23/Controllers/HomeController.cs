using Microsoft.AspNetCore.Mvc;
using Phase2Section4._23.Models;
using SchoolEfDAL;
using System.Diagnostics;

namespace Phase2Section4._23.Controllers
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
            model.InnerJoin = (from st in model.FullList
                               join sub in _context.Subjects
                               on st.StudentID equals sub.StudentID
                               select (dynamic)new
                               {
                                   st.StudentID,
                                   st.Name,
                                   st.ContactEmail,
                                   st.Course,
                                   Subject = sub.Name
                               }).ToList();

            model.LeftJoin = (from st in model.FullList
                              join sub in _context.Subjects
                              on st.StudentID equals sub.StudentID
                              into a
                              from b in a.DefaultIfEmpty(new SubjectModel())
                              select (dynamic)new
                              {
                                  st.StudentID,
                                  st.Name,
                                  st.ContactEmail,
                                  st.Course,
                                  Subject = b.Name
                              }).ToList();

            model.CrossJoin = (from st in model.FullList
                               from sub in _context.Subjects
                               select (dynamic)new
                               {
                                   st.StudentID,
                                   st.Name,
                                   st.ContactEmail,
                                   st.Course,
                                   Subject = sub.Name
                               }).ToList();

            model.GroupJoin = model.FullList.GroupJoin(_context.Subjects, st => st.StudentID,
                sub => sub.StudentID, (st, sub) => (dynamic)
                   new { Key = st.StudentID, Name = st.Name, Subjects = sub }).ToList();

            return View(model);
        }
    }
}