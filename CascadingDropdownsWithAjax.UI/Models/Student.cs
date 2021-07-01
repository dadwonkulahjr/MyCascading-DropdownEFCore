using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CascadingDropdownsWithAjax.UI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name ="First name"),Column(TypeName = "varchar(50)")]
        public string FirstName { get; set; }
        [Required, Display(Name ="Last name"), Column(TypeName = "varchar(50)")]
        public string LastName { get; set; }
        [Required, Column(name:"Student Email", TypeName = "varchar(50)")]
        public string Email { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
