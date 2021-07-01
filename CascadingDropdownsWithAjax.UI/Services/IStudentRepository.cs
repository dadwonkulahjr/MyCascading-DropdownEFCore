using CascadingDropdownsWithAjax.UI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CascadingDropdownsWithAjax.UI.Services
{
    public interface ICourseRepository : IDefaultRepository<Course>
    {
        IEnumerable<SelectListItem> GetDropdownListForCourses();
        void Update(Course courseToUpdate);
    }
}
