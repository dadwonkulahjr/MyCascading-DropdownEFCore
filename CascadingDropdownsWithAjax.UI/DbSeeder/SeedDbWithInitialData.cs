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
            builder.Entity<Course>().HasData(GetCourses());
            builder.Entity<Student>().HasData(GetStudents());
        }
        private static IEnumerable<Course> GetCourses(int studentId=0)
        {
            var courses = new List<Course>()
            {
                new(){CourseId = 1, CourseName = "Razor Pages", CreditHours = 4, StudentId = 1},
                new(){CourseId = 2, CourseName = "Database Fundamentals", CreditHours = 5, StudentId = 1},
                new(){CourseId = 3, CourseName = "Software Development Fundamentals", CreditHours = 4, StudentId = 2},
                new(){CourseId = 4, CourseName = "MVC", CreditHours = 8, StudentId = 3},
                new(){CourseId = 5, CourseName = "EFCore", CreditHours = 5, StudentId = 2},
                new(){CourseId = 6, CourseName = "Web Development", CreditHours = 3, StudentId = 3},
            };

            if (studentId == 0)
            {
                return courses.ToList();
            }
            else
            {
                return courses.Where(c => c.StudentId == studentId);

            }
        }
        private static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
          {
              new(){StudentId = 1, FirstName = "Mike", LastName = "Smith", Email = "mike@m.com"},
              new(){StudentId = 2, FirstName = "Tom", LastName = "Hasting", Email = "tom@m.com"},
              new(){StudentId = 3, FirstName = "Mike", LastName = "Smith", Email = "mike@m.com"},
          };
        }
    }
}
