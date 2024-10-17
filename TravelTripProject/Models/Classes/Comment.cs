using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string UserComment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
        
    }
}