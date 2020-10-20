using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Exam.Models
{
    public class Like
    {   [Key]
        public int LikeId { get; set; }

        public int UserId { get; set; }
        
        public User IdeasLikeByUser { get; set; }

        public int IdeaId { get; set; }
        public Idea UserThatLikeIdea { get; set; }

    }
}