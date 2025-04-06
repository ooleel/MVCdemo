using MVCdemo.Data;

namespace MVCdemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
