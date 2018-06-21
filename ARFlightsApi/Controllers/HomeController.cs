using ARFlightsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARFlightsApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new ARFlightContext())
            {
                //db.Helicopters.Add(new Helicopter() { HelicopterId = 1, HelicopterName = "Port", Origin = "Mel", Destination = "Port Philip", Capacity = 10 });
                //db.SaveChanges();
                
            }
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
