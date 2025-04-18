using curdApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace curdApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly CrudApiContext _context;

        public StudentController(CrudApiContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Students()
        {

            var students = await _context.Students.ToListAsync();
            return Ok(students);

        }

        [HttpPost]
        public async Task<ActionResult<Student>> Student(Student std)
        {
            await _context.AddAsync(std);
            await _context.SaveChangesAsync();
            return Ok(std);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Student>>> Student(int id, Student std)
        {


            if (id != null)
            {
                _context.Entry(std).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(std);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Student>>> Student(int id)
        {

            var students = await _context.Students.FindAsync(id);

            if (students != null)
            {
                _context.Students.Remove(students);
                await _context.SaveChangesAsync();
                return Ok(students);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
