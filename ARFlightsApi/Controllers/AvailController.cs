using ARFlightsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ARFlightsApi.Controllers
{
    public class AvailController : ApiController
    {
        [HttpPost]
        public Object CheckAvailability(DateTime from, DateTime to, int pax)
        {
            ARFlightContext entity = new ARFlightContext();
            return entity.Bookings.Where(b => b.BookingDate >= from && b.BookingDate <= to)
                .Select(b => new
                {
                    b.BookingDate,
                    b.Helicopter.HelicopterName,
                    b.Helicopter.Capacity,
                    b.Booked,
                    Available = (bool)((b.Booked < b.Helicopter.Capacity) && (b.Helicopter.Capacity - b.Booked >= pax) )
                }).ToList();
        }
    }
}
