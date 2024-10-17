using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}