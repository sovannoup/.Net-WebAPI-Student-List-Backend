namespace Backend_Student_List.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age) {
            this.Name = name;
            this.Age = age;
        }
    }
}
