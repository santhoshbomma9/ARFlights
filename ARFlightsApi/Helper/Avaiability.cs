using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ARFlightsApi.Helper
{
    public class Availability
    {
        [Display(Name = "From date")]
        [Required]
        public DateTime from { get; set; }

        [Display(Name = "To date")]
        [Required]
        public DateTime to { get; set; }

        [Display(Name = "No of Passengers")]
        [Required]
        [Range(1,10)]
        public int Pax { get; set; }
    }
}