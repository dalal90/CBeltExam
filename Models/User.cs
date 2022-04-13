using System;
using System.ComponentModel.DataAnnotations;//validation
using System.ComponentModel.DataAnnotations.Schema;//not mapped
using System.Collections.Generic;//list

namespace BeltExam.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2,ErrorMessage="First Name at least 2 characters")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2,ErrorMessage="Last Name at least 2 characters")]
        public string LastName {get;set;}

        [Required]
        [MinLength(3,ErrorMessage="Username between 3 and 15 characters")]
        [MaxLength(15, ErrorMessage = "Username between 3 and 15 characters")]
        public string UserName {get;set;}

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]

        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        // Will not be mapped to your users table!

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        
        // navigation 
        
        public List<Association> addedHobbies {get;set;}
        public List<Hobby> createddHobbies {get;set;}

    }
}