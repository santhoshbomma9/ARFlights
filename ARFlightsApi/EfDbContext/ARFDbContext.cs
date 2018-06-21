using ARFlightsApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ARFlightsApi.EfDbContext
{
    public class ARFlightContext : DbContext
    {
        public DbSet<Helicopter> Helicopters { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }

}