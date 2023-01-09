using Backend_Student_List.Controllers.Request;
using Backend_Student_List.Models;

namespace Backend_Student_List.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        Student CreateStudent(StudentRequest student);
        String EditStudent(Student student);
        String DeleteStudent(int id);
    }
}
