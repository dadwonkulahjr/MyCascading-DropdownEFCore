using CascadingDropdownsWithAjax.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CascadingDropdownsWithAjax.UI.Pages.Admin.Student
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        [BindProperty]
        public Models.Student StudentObj { get; set; }
        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult OnGet(int? id)
        {
            StudentObj = new();
            if (id != null)
            {
                StudentObj = _unitOfWork.Student.GetFirstOrDefaultType(s => s.Id == id);
                if (StudentObj != null)
                {
                    return Page();
                }
            }


            return Page();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            if (StudentObj.Id == 0)
            {
                //Add 
                _unitOfWork.Student.AddTypeToDb(StudentObj);
                _unitOfWork.Save();
            }
            else
            {
                //Update
                _unitOfWork.Student.Update(StudentObj);
            }



          
            return RedirectToPage("./Index");
        }
    }
}
