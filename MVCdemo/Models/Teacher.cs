using MVCdemo.Data;

namespace MVCdemo.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
