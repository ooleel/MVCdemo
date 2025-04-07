using MVCdemo.Areas.Admin.Models;

namespace MVCdemo.Areas.Admin.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        //public ICollection<Course> Courses { get; set; }
    }
}
