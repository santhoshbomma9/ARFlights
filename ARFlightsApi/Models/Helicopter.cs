using System;
using System.Collections.Generic;
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
}