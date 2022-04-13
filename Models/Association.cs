using System.ComponentModel.DataAnnotations;
using System;
namespace BeltExam.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }
        
        public int HobbyId { get; set; }

        public Hobby UsersHobbies { get; set; }

        public int UserId { get; set; }

        public User HobbiesUsers { get; set; }


    }
}