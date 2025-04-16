using APIcrud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIcrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DbApiContext context;

        public StudentController(DbApiContext context)
        {
            this.context = context;
        }

        // GET: api/Student

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await context.Students.ToListAsync();
            return Ok(data);
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentbyId(Guid id)
        {
            var student = await context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        // POST: api/Student
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
            return Ok(student);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateStudent(Guid id, Student student)
        {

            if (id != student.Id)
            {
                return BadRequest();
            }
            context.Entry(student).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(student);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            var student = await context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            context.Students.Remove(student);
            await context.SaveChangesAsync();

            return NoContent();
        }
    }
}
