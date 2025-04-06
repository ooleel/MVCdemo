﻿namespace MVCdemo.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //FK
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        //many-to-many for students 
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}

