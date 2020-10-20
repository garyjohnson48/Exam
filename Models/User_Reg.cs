using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;



namespace Exam.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }

        [Required(ErrorMessage="Name is Required")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z\s]{1,40}$", 
         ErrorMessage = "Characters are not allowed.")]
        public string Name {get; set; }

        [Required(ErrorMessage="Name is Required")]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z0-9]{1,40}$", 
         ErrorMessage = "Characters are not allowed.")]
        public string Alias { get; set; }


        [Required(ErrorMessage="Email is Required")]
        [EmailAddress]
        public string Email {get; set; }


        [Required(ErrorMessage="Password is Required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string Password {get; set; }


        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Idea> IdeasCreated { get; set; }

        public List<Like> Liked { get; set; }


    }
}
