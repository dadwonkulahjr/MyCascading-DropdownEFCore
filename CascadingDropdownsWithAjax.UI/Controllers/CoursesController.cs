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
    public class CoursesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoursesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var courses = _unitOfWork.Course.GetAll().ToList();
        //    return Json(new { data = courses });
        //}

    }
}
