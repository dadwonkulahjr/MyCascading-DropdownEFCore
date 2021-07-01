using CascadingDropdownsWithAjax.UI.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CascadingDropdownsWithAjax.UI.Services
{
    public interface IStudentRepository : IDefaultRepository<Student>
    {
        IEnumerable<SelectListItem> GetDropdownListForStudents();
        void Update(Student studentToUpdate);
    }
}
