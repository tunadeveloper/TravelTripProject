using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class WhosMe
    {
        [Key]
        public int Id { get; set; }
        public string ProfileImage { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
    }
}