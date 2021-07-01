using System;

namespace CascadingDropdownsWithAjax.UI.Services
{
    public interface IUnitOfWork : IDisposable
    {
        public IStudentRepository Student { get; }
        void Save();
    }
}
