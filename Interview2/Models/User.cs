using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Interview2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide your first name!")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Please provide your last name!")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "Please provide your email address!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please provide your mobile number!")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "Please provide a valid date of birth!")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        
        public DateTime? Modified { get; set; }
    }
}