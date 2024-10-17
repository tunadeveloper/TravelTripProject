using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
    }
}