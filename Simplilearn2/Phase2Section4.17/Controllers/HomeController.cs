using Microsoft.AspNetCore.Mvc;
using Phase2Section4._17.Models;
using System.Diagnostics;
using StudentAdoDAL;
using System.Collections;

namespace Phase2Section4._17.Controllers
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
            StudentDAL dal = new StudentDAL(_configuration.GetConnectionString("SchoolConnection"));

            IEnumerable<Student> students = dal.GetAllStudents();
            ViewData["students"] = (List<Student>)students;

            List<Student> toList = students.ToList();
            ViewData["toList"] = toList;

            Student[] toArray = students.ToArray();
            ViewData["toArray"] = toArray;

            var gradesLookup = students.ToLookup(st => st.Grades);
            List<Student> listLookup = new List<Student>();
            foreach (Student student in gradesLookup[85])
                listLookup.Add(student);
            ViewData["lookupList"] = listLookup;

            IEnumerable<Student> cast = students.Cast<Student>();
            ViewData["cast"] = cast;

            ArrayList arrayMixed = new ArrayList();
            arrayMixed.Add("string 1");
            arrayMixed.Add(12);
            arrayMixed.Add(DateTime.Now);
            arrayMixed.Add(toArray[0]);
            arrayMixed.Add("string 2");
            List<Student> ofType = arrayMixed.OfType<Student>().ToList();
            ViewData["ofType"] = ofType;

            IEnumerable<Student> ienum = toList.AsEnumerable();
            ViewData["ienum"] = ienum;

            IQueryable<Student> query = students.AsQueryable().
                Where(st => st.Grades < 90);
            ViewData["query"] = query;

            Dictionary<string, string> dictionary = students.ToDictionary(st => st.Name, st => st.Address);
            ViewData["dictionary"] = dictionary;

            return View();
        }
    }
}