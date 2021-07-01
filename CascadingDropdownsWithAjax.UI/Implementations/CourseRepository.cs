using CascadingDropdownsWithAjax.UI.Data;
using CascadingDropdownsWithAjax.UI.Models;
using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CascadingDropdownsWithAjax.UI.Implementations
{

    public class StudentRepository : DefaultRepository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public StudentRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IEnumerable<SelectListItem> GetDropdownListForStudents()
        {
            return _applicationDbContext.Student.Select(s => new SelectListItem()
            {
                Text = s.FullName,
                Value = s.Id.ToString()

            }).ToList();
        }
        public void Update(Student studentToUpdate)
        {
            var findStudentFromDb = _applicationDbContext.Student.Find(studentToUpdate.Id);
            if (findStudentFromDb != null)
            {
                findStudentFromDb.FirstName = studentToUpdate.FirstName;
                findStudentFromDb.LastName = studentToUpdate.LastName;
                findStudentFromDb.Email = studentToUpdate.Email;
                _applicationDbContext.SaveChanges();
            }


        }
    }
}
