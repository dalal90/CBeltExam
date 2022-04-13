using System;
using System.ComponentModel.DataAnnotations;//validation
using System.ComponentModel.DataAnnotations.Schema;//not mapped
using System.Collections.Generic;//list

namespace BeltExam.Models
{
    public class Hobby
    {
                [Key]
        public int HobbyId { get; set; }

        [Required]
        [MinLength (2, ErrorMessage = "Name must be at least 2 characters")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }


        public int UserId {get;set;}
        public User Creator {get;set;} //One to Many relation 
        
        public List<Association> Enthusiasts {get;set;}

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}