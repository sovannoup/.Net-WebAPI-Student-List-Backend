using Backend_Student_List.Models;

namespace Backend_Student_List.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetStudentById(int id);
        List<Student> CreateStudent(Student student);
        List<Student>? EditStudentById(int id, Student student);
        List<Student>? DeleteStudent(int id);
    }
}
