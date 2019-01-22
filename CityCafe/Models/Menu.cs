using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCafe.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        public string UserName { get; set; }
        public string MenuTitle { get; set; }
        public string starter { get; set; }
        public string Main { get; set; }
        public string Desert { get; set; }
        public string ImageUrl { get; set; }
    }
}