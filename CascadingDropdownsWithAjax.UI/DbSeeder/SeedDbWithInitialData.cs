using CascadingDropdownsWithAjax.UI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CascadingDropdownsWithAjax.UI.DbSeeder
{
    public static class SeedDbWithInitialData
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(GetStudents());
            builder.Entity<Course>().HasData(GetCourses());
        }
        private static IEnumerable<Course> GetCourses()
        {
            return new List<Course>()
            {
                new(){Id = 1, CourseName = "Computer Fundamental", CreditHours = 4,
                CourseNumber = 101},
                new(){Id = 2, CourseName = "Mathematics", CreditHours = 4, 
                CourseNumber = 107},
                new(){Id = 3, CourseName = "English", CreditHours = 3, CourseNumber = 101},
                new(){Id = 4, CourseName = "Desktop Management", CreditHours = 4, CourseNumber = 102},
                new(){Id = 5, CourseName = "Server Fundamental (MTA)", CreditHours = 4,CourseNumber = 201},
                new(){Id = 6, CourseName = "Security Fundamental", CreditHours = 4,CourseNumber = 201},
                new(){Id = 7, CourseName = "EFCore", CreditHours = 8, CourseNumber = 202},
                new(){Id = 8, CourseName = "Database Development", CreditHours = 3,CourseNumber = 302},
                new(){Id = 9, CourseName = "MVC", CreditHours = 9, CourseNumber = 302},
                new(){Id = 10, CourseName = "Razor Pages", CreditHours = 7, CourseNumber = 402},
                new(){Id = 11, CourseName = "Web Development", CreditHours = 6,
                CourseNumber = 402},
                new(){Id = 12, CourseName = "Software Development", CreditHours = 11, CourseNumber = 402},
            };
        }
        private static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
          {
              new(){Id = 1, FirstName = "Mike", LastName = "Smith", Email = "mike@m.com",
              },
              new(){Id = 2, FirstName = "Tom", LastName = "Hasting", Email = "tom@m.com"},
              new(){Id = 3, FirstName = "iamtuse", LastName = "theProgrammer", Email = "iamtuse@t.com"},
          };
        }
    }
}
