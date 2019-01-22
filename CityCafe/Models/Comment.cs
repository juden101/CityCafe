using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCafe.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int MenuId { get; set; }
        public string BodyText { get; set; }
        public DateTime CommentDate { get; set; }
        public string Username { get; set; }

    }
}