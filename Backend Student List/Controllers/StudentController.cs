using Backend_Student_List.Models;
using Backend_Student_List.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Student_List.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var result = _studentService.GetStudents();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var result = _studentService.GetStudentById(id);
            if (result == null)
            {
                return NotFound("Student Not Found");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> CreateStudent(Student student)
        {
            var result = _studentService.CreateStudent(student);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Student>>> EditStudentById(int id, Student student)
        {
            var result = _studentService.EditStudentById(id, student);
            if (result is null)
            {
                return NotFound("Student Not Found");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudentById(int id)
        {
            var result = _studentService.DeleteStudent(id);
            if (result is null)
            {
                return NotFound("Student Not Found");
            }
            return Ok(result);
        }
    }
}
