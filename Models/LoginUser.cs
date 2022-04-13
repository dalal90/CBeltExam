using System.ComponentModel.DataAnnotations;

namespace BeltExam.Models
{
    public class LoginUser
    {
        [Required]
        public string logUserName {get;set;}
        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string logPassword {get;set;}
    }
}