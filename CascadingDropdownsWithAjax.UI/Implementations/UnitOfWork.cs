using CascadingDropdownsWithAjax.UI.Data;
using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.EntityFrameworkCore;
using System;

namespace CascadingDropdownsWithAjax.UI.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            Student = new StudentRepository(applicationDbContext);
        }
        public IStudentRepository Student { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
