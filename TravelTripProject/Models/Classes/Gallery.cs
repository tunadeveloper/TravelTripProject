using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Gallery
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        public string ImageDescription { get; set; }
    }
}