using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Classes
{
    public class HomeBlog
    {
        public int Id { get; set; }
        public List<Home> Homes { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<WhosMe> WhosMes { get; set; }
    }
}