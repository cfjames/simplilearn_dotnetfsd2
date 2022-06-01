using Microsoft.AspNetCore.Mvc;
using Phase2Section2._24.Repository;
using SchoolEfDAL;

namespace Phase2Section2._24.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;
        private SchoolContext _schoolDb;
        private IGenericRepository<StudentModel> _repository = null;

        public StudentsController(ILogger<StudentsController> logger, SchoolContext schoolDb)
        {
            _logger = logger;
            _schoolDb = schoolDb;
            _repository = new GenericRepository<StudentModel>(_schoolDb);
        }

        public IActionResult Index()
        {
            var students = _repository.SelectAll();
            return View(students);
        }

        public ActionResult Details(int id)
        {
            var student = _repository.SelectByID(id);
            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentID,Name,Address,ContactEmail,Course,Grades")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(studentModel);
                 _repository.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _repository.SelectAll() == null)
            {
                return NotFound();
            }

            var studentModel = _repository.SelectByID(id);
            if (studentModel == null)
            {
                return NotFound();
            }
            return View(studentModel);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentID,Name,Address,ContactEmail,Course,Grades")] StudentModel studentModel)
        {
            if (id != studentModel.StudentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _repository.Update(studentModel);
                    _repository.Save();
                }
                catch //(DbUpdateConcurrencyException)
                {
                    //    if (!StudentModelExists(studentModel.StudentID))
                    //    {
                    //        return NotFound();
                    //    }
                    //    else
                    //    {
                    //        throw;
                    //    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _repository.SelectAll() == null)
            {
                return NotFound();
            }

            var studentModel = _repository.SelectByID(id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_repository.SelectAll() == null)
            {
                return Problem("Entity set 'SchoolContext.Students'  is null.");
            }
            var studentModel = _repository.SelectByID(id);
            if (studentModel != null)
            {
                _repository.Delete(studentModel);
            }

            _repository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
