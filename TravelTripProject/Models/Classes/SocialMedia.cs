using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class SocialMedia
    {
        [Key]
        public int Id { get; set; }
        public string SocialMediaName { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
    }
}