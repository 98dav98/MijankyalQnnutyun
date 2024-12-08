using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MijankyalQnnutyun.Models;

namespace MijankyalQnnutyun.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DekanatDbContext _context;
        public StudentController(DekanatDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<Student> GetPersonById(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(p => p.Id == id);
        }

        [HttpGet]
        public async Task<List<Student>> GetAllPeople()
        {
            return await _context.Students.ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePerson(Student student)
        {
            var existingStudent = _context.Students.FirstOrDefault(p => p.Id == student.Id);
            if (existingStudent != null)
            {
                existingStudent.YearOfEnrollment = student.YearOfEnrollment;
                existingStudent.DateOfBirth = student.DateOfBirth;
                existingStudent.Nsf = student.Nsf;
                await _context.SaveChangesAsync();
            }
            return Ok();
        }

        [HttpDelete]
        public async void DeletePerson(int id)
        {
            var personToDelete = await _context.Students.FirstOrDefaultAsync(p => p.Id == id);
            if (personToDelete != null)
            {
                _context.Students.Remove(personToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
