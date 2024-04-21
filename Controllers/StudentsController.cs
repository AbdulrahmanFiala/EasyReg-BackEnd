using EasyReg_BackEnd.Data;
using EasyReg_BackEnd.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyReg_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DataContext _context;

        public StudentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var students = await _context.Students.ToListAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student is null)
                return NotFound("Student Not Found");

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(Student updatedStudent)
        {
            var dbStudent = await _context.Students.FindAsync(updatedStudent.Id);
            if (dbStudent is null)
                return NotFound("Student Not Found");

            dbStudent.Name = updatedStudent.Name;
            dbStudent.Phone = updatedStudent.Phone;
            dbStudent.Email = updatedStudent.Email;
            dbStudent.Age = updatedStudent.Age;

            await _context.SaveChangesAsync();

            return Ok(dbStudent);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var dbStudent = await _context.Students.FindAsync(id);
            if (dbStudent is null)
                return NotFound("Student Not Found");

            _context.Students.Remove(dbStudent);
            await _context.SaveChangesAsync();

            return Ok(dbStudent);
        }

    }
}
