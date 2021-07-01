using CascadingDropdownsWithAjax.UI.Data;
using CascadingDropdownsWithAjax.UI.Models;
using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CascadingDropdownsWithAjax.UI.Implementations
{

    //public class CourseRepository : DefaultRepository<Course>, ICourseRepository
    //{
    //    private readonly ApplicationDbContext _applicationDbContext;
    //    public CourseRepository(ApplicationDbContext applicationDbContext)
    //        : base(applicationDbContext)
    //    {
    //        _applicationDbContext = applicationDbContext;
    //    }
    //    public IEnumerable<SelectListItem> GetDropdownListForCourses()
    //    {
    //        return _applicationDbContext.Student.Select(s => new SelectListItem()
    //        {
    //            Text = s.FullName,
    //            Value = s.StudentId.ToString()

    //        }).ToList();
    //    }
    //    //public void Update(Course courseToUpdate)
    //    //{
    //    //    var findCourseFromDb = _applicationDbContext.Course.Find(courseToUpdate.CourseId);
    //    //    if (findCourseFromDb != null)
    //    //    {
    //    //        findCourseFromDb.CourseName = courseToUpdate.CourseName;
    //    //        findCourseFromDb.CourseNumber = courseToUpdate.CourseNumber;
    //    //        findCourseFromDb. = courseToUpdate.Email;
    //    //        _applicationDbContext.SaveChanges();
    //    //    }


    //    //}
    //}
}
