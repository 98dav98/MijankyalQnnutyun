using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MijankyalQnnutyun.Dtos.Student;
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
        public async Task<IActionResult> Create(CreateStudentRequest student)
        {
            var studentModel = student.ToStudentFromCreateDto();
            await _context.Students.AddAsync(studentModel);
            await _context.SaveChangesAsync();
            return Ok(CreatedAtAction(nameof(GetById),new {id = studentModel.Id}, studentModel));
        }

        [HttpGet("{id}")]
        public async Task<Student> GetById(int id)
        {
            return await _context.Students.FirstOrDefaultAsync(p => p.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _context.Students.ToListAsync();
            return Ok(res);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Student student)
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
        public async void Delete(int id)
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
