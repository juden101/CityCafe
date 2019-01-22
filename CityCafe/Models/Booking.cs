using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CityCafe.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int TableId { get; set; }
        public DateTime BookingTime { get; set; }
        public string UserName { get; set; }
    }
}