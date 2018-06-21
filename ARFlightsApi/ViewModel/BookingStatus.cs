using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARFlightsApi.ViewModel
{
    public class BookingStatus
    {
        public DateTime Date { get; set; }
        public string HelicopterName { get; set; }
        public int Capacity { get; set; }
        public int Booked { get; set; }
        public int Available { get; set; }
    }
}