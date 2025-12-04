namespace Contemp_FInal_Project.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Program { get; set; }
        public string Year { get; set; }

        public Student() { }

        public Student(int id, string name, string birthday, string program, string year)
        {
            Id = id;
            Name = name;
            Birthday = birthday;
            Program = program;
            Year = year;
        }
    }
}
