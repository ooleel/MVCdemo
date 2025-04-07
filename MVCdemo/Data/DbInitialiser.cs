using MVCdemo.Models;

namespace MVCdemo.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any()) 
            {
                return; // DB has been seeded
            }

            //Add sample teachers
            var teachers = new Teacher[]
            {
                new Teacher { FullName = "Peter H.", Department = "Programming" },
                new Teacher { FullName = "Shanti H.", Department = "Strategy analysis" },
                new Teacher { FullName = "Tyson T.", Department = "Mobile" },
            };
            context.Teachers.AddRange(teachers);
            context.SaveChanges();

            //Add sample courses
            var courses = new Course[]
            {
                new Course 
                { 
                    Title = "Programming", 
                    Description = "Develop web applications using C#, .NET Core. ASP.NET Core and Entity Framework Core.", 
                    TeacherId = teachers[0].Id 
                },
                new Course 
                { 
                    Title = "Strategy analysis", 
                    Description = "Learn about project management.", 
                    TeacherId = teachers[1].Id 
                },
                new Course 
                { 
                    Title = "Mobile Development", 
                    Description = "Learn how to build mobile applications.", 
                    TeacherId = teachers[2].Id 
                }
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            //Add sample students
            var students = new Student[] 
            {
                new Student { FullName = "Leeloo S." },
                new Student { FullName = "Logan W." }
            };
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
