using CascadingDropdownsWithAjax.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CascadingDropdownsWithAjax.UI.ViewModels
{
    public class StudentCourseViewModel
    {
        public StudentCourseViewModel()
        {
            Courses = new();
            Students = new();
        }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
    }
}
