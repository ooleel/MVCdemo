﻿namespace MVCdemo.Models
{
    public class Teacher
    {
        public int Id { get;  set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
