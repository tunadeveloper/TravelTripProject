using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.messages.OrderByDescending(x => x.Id).Take(8).ToList();
            return View(values);
        }

        public PartialViewResult PartialDasboardBlog()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialDasboardComment()
        {
            var values = context.Comments.OrderByDescending(x => x.Id).Take(5).ToList();
            return PartialView(values);
        }

        
    }
}