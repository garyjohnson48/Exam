using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Exam.Models
{
    public class Login_User
    {   [Key]
        public int Login_UserId { get; set; 
        }
        [Required]
        [EmailAddress]
        public string Email {get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set; }


    }
}
