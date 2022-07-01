using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolEfDAL;

namespace Phase2Section5._7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentModel>>> Get()
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            return await _context.Students.ToListAsync();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentModel>> Get(int id)
        {
          if (_context.Students == null)
          {
              return NotFound();
          }
            var studentModel = await _context.Students.FindAsync(id);

            if (studentModel == null)
            {
                return NotFound();
            }

            return studentModel;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<StudentModel>> Put(int id, StudentModel studentModel)
        {
            if (id != studentModel.StudentID)
            {
                return BadRequest();
            }

            _context.Entry(studentModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return studentModel;
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentModel>> Post(StudentModel studentModel)
        {
          if (_context.Students == null)
          {
              return Problem("Entity set 'SchoolContext.Students'  is null.");
          }
            _context.Students.Add(studentModel);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("Get", new { id = studentModel.StudentID }, studentModel);
            return studentModel;
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Students == null)
            {
                return Problem("Entity set 'SchoolContext.Students'  is null.");
            }
            var studentModel = await _context.Students.FindAsync(id);
            if (studentModel == null)
            {
                return NotFound();
            }

            _context.Students.Remove(studentModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentModelExists(int id)
        {
            return (_context.Students?.Any(e => e.StudentID == id)).GetValueOrDefault();
        }
    }
}
