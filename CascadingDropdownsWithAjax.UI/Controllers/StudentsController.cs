using CascadingDropdownsWithAjax.UI.Models;
using CascadingDropdownsWithAjax.UI.Services;
using CascadingDropdownsWithAjax.UI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CascadingDropdownsWithAjax.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _unitOfWork.Student.GetAll().ToList();
            return Json(new { data = students });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var obj = _unitOfWork.Student.GetFirstOrDefaultType(e => e.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error why deleting." });
            }

           
            _unitOfWork.Student.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });

        }

    }
}
