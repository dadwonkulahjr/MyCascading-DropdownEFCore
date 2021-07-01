using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadingDropdownsWithAjax.UI.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Description"), Column(TypeName ="varchar(50)")]
        public string CourseName { get; set; }
        [Display(Name = "Cr. Hrs"), Column(name:"Cr. Hrs", TypeName ="int")]
        public int CreditHours { get; set; }
        [Display(Name = "No."), Column(TypeName = "int")]
        public int CourseNumber { get; set; }
        
    }
}
