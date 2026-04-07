using Microsoft.AspNetCore.Mvc;
using Student_Management_System.Models;
using Student_Management_System.Services;
using Microsoft.AspNetCore.Authorization;

namespace Student_Management_System.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetStudents());

        [HttpPost]
        public async Task<IActionResult> Add(Student student)
        {
            await _service.AddStudent(student);
            return Ok("Added");
        }

        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            await _service.UpdateStudent(student);
            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteStudent(id);
            return Ok("Deleted");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _service.GetStudentById(id);
            return Ok(student);
        }
        [HttpGet("search")]
        public async Task<IActionResult> Search(string name)
        {
            var students = await _service.SearchByName(name);
            return Ok(students);
        }
    }
}
