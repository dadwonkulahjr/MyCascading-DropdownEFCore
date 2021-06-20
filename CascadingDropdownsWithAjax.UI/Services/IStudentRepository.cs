using CascadingDropdownsWithAjax.UI.Models;
using System.Collections.Generic;

namespace CascadingDropdownsWithAjax.UI.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        IEnumerable<Course> GetCourses(int studentId);

    }
}
