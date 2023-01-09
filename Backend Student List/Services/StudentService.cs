using Backend_Student_List.Context;
using Backend_Student_List.Controllers.Request;
using Backend_Student_List.Models;

namespace Backend_Student_List.Services
{
    public class StudentService : IStudentService
    {

        ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }
        /*
        private readonly static List<Student> Students = new List<Student>
            {
                new Student {Id = 1, Name = "Noup Sovan", Age = 21},
                new Student {Id = 2, Name = "Jonh Wick", Age = 33},
                new Student {Id = 3, Name = "Yaga Kura", Age = 19},
            };
        */

        public Student CreateStudent(StudentRequest student)
        {
            Student newStudent= new(student.name, student.age);
            _context.Students.Add(newStudent);
            _context.SaveChanges();
            return newStudent;
        }

        public String DeleteStudent(int id)
        {
            var isExist = _context.Students.FirstOrDefault(x => x.Id == id);
            if (isExist is null)
            {
                return "Student not found";
            }
            _context.Students.RemoveRange(isExist);
            _context.SaveChanges();
            return "Success";
        }

        public String EditStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return "Success";
        }

        public Student GetStudentById(int id)
        {
            var isExist = _context.Students.FirstOrDefault(x => x.Id == id);
            if (isExist is null)
            {
                return null;
            }
            return isExist;
        }

        public List<Student> GetStudents()
        {
            var students = _context.Students.ToList();
            return students;
        }
    }
}
