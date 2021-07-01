using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CascadingDropdownsWithAjax.UI.Pages.Admin.Course
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public Models.Student CourseObj { get; set; }
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //public IActionResult OnGet(int? id)
        //{
        //    CourseObj = new();
        //    if (id != null)
        //    {
        //        CourseObj = _unitOfWork.Course.GetFirstOrDefaultType(c => c.CourseId == id);
        //        if (CourseObj != null)
        //        {
        //            return Page();
        //        }
        //    }


        //    return Page();

        //}
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            if (CourseObj.Id == 0)
            {
                //Add 
                _unitOfWork.Student.AddTypeToDb(CourseObj);
                _unitOfWork.Save();
            }
            else
            {
                //Update
                _unitOfWork.Student.Update(CourseObj);
            }



          
            return RedirectToPage("./Index");
        }
    }
}
