namespace ARFlightsApi.Migrations
{
    using ARFlightsApi.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ARFlightsApi.EfDbContext.ARFlightContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ARFlightsApi.Models.ARFlightContext";
        }

        protected override void Seed(ARFlightsApi.EfDbContext.ARFlightContext context)
        {
            context.Helicopters.AddOrUpdate(x => x.HelicopterId,
                new Helicopter() { HelicopterId = 1, HelicopterName = "Port", Origin = "Mel", Destination = "Port Philip", Capacity = 10 },
                new Helicopter() { HelicopterId = 2, HelicopterName = "Apostles", Origin = "Mel", Destination = "12 Apostles", Capacity = 10 },
                new Helicopter() { HelicopterId = 3, HelicopterName = "Philip", Origin = "Mel", Destination = "Philip Island", Capacity = 10 },
                new Helicopter() { HelicopterId = 4, HelicopterName = "Ballarat", Origin = "Mel", Destination = "Ballarat", Capacity = 10 },
                new Helicopter() { HelicopterId = 5, HelicopterName = "Arart", Origin = "Mel", Destination = "Arart", Capacity = 10 }
                );
            Random r = new Random();
            foreach (DateTime date in EachDay(new DateTime(2018, 01, 01), new DateTime(2019, 01, 01)))
            { 
                for (int i=1; i<=5; i++)
                {
                    context.Bookings.AddOrUpdate(x => x.BookingId,
                        new Booking() { BookingId = 1, BookingDate = date, HelicopterId = i, Booked = r.Next(1, 11) });
                }
            }
        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }
    }
}
