using ARFlightsApi.Helper;
using ARFlightsApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ARFlightsApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Help", new { area = "" });
        }
        
        public ActionResult CheckAvail()
        {
            return View(new Availability());
        }

        //[HttpPost]
        //public async Task<ActionResult> CheckAvailAsync(Availability avail)
        //{
        //    var pairs = new List<KeyValuePair<string, string>>
        //    {
        //        new KeyValuePair<string, string>("from", avail.from.ToShortTimeString()),
        //        new KeyValuePair<string, string>("to", avail.to.ToShortTimeString()),
        //        new KeyValuePair<string, string>("pax", avail.Pax.ToString())
        //    };

        //    var content = new FormUrlEncodedContent(pairs);

        //    var client = new HttpClient { BaseAddress = new Uri("http://localhost:2523") };

        //    call sync
        //    var response = client.PostAsync("/api/Avail", content).Result;
        //    if (response.IsSuccessStatusCode)
        //    {

        //    }
        //    return View("CheckAvail");
        //}
    }
}
