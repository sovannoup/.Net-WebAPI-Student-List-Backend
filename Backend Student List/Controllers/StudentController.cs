using Backend_Student_List.Controllers.Request;
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
        public  List<Student> GetStudents()
        {
            List<Student> students = _studentService.GetStudents();
            return students;
        }

        [HttpGet("{id}")]
        public  Student GetStudentById(int id)
        {
            Student student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return null;
            }
            return student;
        }

        [HttpPost]
        public  Student CreateStudent(StudentRequest student)
        {
            Student res = _studentService.CreateStudent(student);
            return res;
        }

        [HttpPut]
        public  String EditStudent(Student student)
        {
            return _studentService.EditStudent(student);
        }

        [HttpDelete("{id}")]
        public  String DeleteStudentById(int id)
        {
            return _studentService.DeleteStudent(id);
        }
    }
}
