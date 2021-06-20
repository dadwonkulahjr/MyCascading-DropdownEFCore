using CascadingDropdownsWithAjax.UI.Data;
using CascadingDropdownsWithAjax.UI.Models;
using CascadingDropdownsWithAjax.UI.Services;
using System.Collections.Generic;
using System.Linq;

namespace CascadingDropdownsWithAjax.UI.Implementations
{
    public class StudentContextRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public StudentContextRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<Course> GetCourses(int studentId)
        {
            return _applicationDbContext.Course.Where(c => c.StudentId == studentId);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _applicationDbContext.Student.ToList();
        }
    }
}
