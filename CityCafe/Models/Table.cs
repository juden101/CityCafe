using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCafe.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }
        public int NoOfSeats { get; set; }


    }
}