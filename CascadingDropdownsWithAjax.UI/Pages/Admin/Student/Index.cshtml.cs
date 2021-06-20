using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace CascadingDropdownsWithAjax.UI.Pages.Admin.Student
{
    public class IndexModel : PageModel
    {
        private readonly IStudentRepository _studentRepo;
        [BindProperty(SupportsGet = true)]
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public SelectList Students { get; set; }
        public IndexModel(IStudentRepository studentRepository)
        {
            _studentRepo = studentRepository;
        }
        public void OnGet()
        {
            Students = new(_studentRepo.GetStudents(), nameof(Models.Student.StudentId),
                nameof(Models.Student.FullName));
        }

        public JsonResult OnGetCourses()
        {
            return new JsonResult(_studentRepo.GetCourses(StudentId));
        }
    }
}
