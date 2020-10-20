using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Exam.Models
{
    public class Idea
    {   [Key]
        public int IdeaId { get; set; }

        [MinLength(5)]
        [Required]
        
        public string IdeaMessage { get; set; }
        public int UserId { get; set; }
        public User IdeaCreator { get; set; }

        public List<Like> Likes { get; set; }


    }


}