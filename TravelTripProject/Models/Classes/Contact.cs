using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string Map { get; set; }
        public string Description { get; set; }
    }
}