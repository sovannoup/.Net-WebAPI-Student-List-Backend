using Backend_Student_List.Models;

namespace Backend_Student_List.Services
{
    public class StudentService : IStudentService
    {

        private readonly static List<Student> Students = new List<Student>
            {
                new Student {Id = 1, Name = "Noup Sovan", Age = 21},
                new Student {Id = 2, Name = "Jonh Wick", Age = 33},
                new Student {Id = 3, Name = "Yaga Kura", Age = 19},
            };

        public List<Student> CreateStudent(Student student)
        {
            Students.Add(student);
            return Students;
        }

        public List<Student>? DeleteStudent(int id)
        {
            var Student = Students.Find(x => x.Id == id);
            if (Student is null)
            {
                return null;
            }
            Students.Remove(Student);
            return Students;
        }

        public List<Student>? EditStudentById(int id, Student student)
        {
            var Student = Students.Find(x => x.Id == id);
            if (Student is null)
            {
                return null;
            }
            Student.Name = student.Name;
            Student.Age = student.Age;

            return Students;
        }

        public Student GetStudentById(int id)
        {
            var Student = Students.Find(x => x.Id == id);
            if (Student is null)
            {
                return null;
            }
            return Student;
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
