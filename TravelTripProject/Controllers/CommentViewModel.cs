using System.Collections.Generic;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    internal class CommentViewModel
    {
        public List<Comment> Comments { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}