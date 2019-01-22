using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCafe.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string ReviewName { get; set; }
        public DateTime ReviewDate { get; set; }
        public string ReviewText { get; set; }
    }
}