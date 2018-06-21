using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ARFlightsApi.Models
{
    public class Helicopter
    {
        public int HelicopterId { get; set; }
        public string HelicopterName { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Capacity { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }

    public class Booking
    {
        public int BookingId { get; set; }
        public System.DateTime BookingDate { get; set; }        
        public int Booked { get; set; }
        public int HelicopterId { get; set; }
        public virtual Helicopter Helicopter { get; set; }        
    }

    public class ARFlightContext : DbContext
    {
        public DbSet<Helicopter> Helicopters { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }

}