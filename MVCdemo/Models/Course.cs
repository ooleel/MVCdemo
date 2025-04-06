namespace MVCdemo.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //FK
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //many-to-many for students 
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}

