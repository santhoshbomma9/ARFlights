using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ARFlightsApi.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public System.DateTime BookingDate { get; set; }        
        public int Booked { get; set; }
        public int HelicopterId { get; set; }
        public virtual Helicopter Helicopter { get; set; }        
    }

}