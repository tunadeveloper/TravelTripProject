using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Home
    {
        [Key]
        public int Id { get; set; }
        public string HeadImage { get; set; }
        public string HeadImageTitle { get; set; }
        public string HeadImageDescription { get; set; }
    }
}