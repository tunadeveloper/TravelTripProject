using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        public ActionResult UpdateDescription(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value); 
        }

        [HttpPost]
        public ActionResult UpdateDescription(About about)
        {
            var value = context.Abouts.Find(about.Id);
            value.Description = about.Description;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminAbout");
        }

        public ActionResult DeleteDescription(int id)
        {
            var value = context.Abouts.Find(id);
            context.Abouts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminAbout");
        }

        public ActionResult UpdateImage(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateImage(About about)
        {
            var value = context.Abouts.Find(about.Id);
            value.Image = about.Image;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminAbout");
        }

        public ActionResult CreateDescription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDescription(About about)
        {
            var value = context.Abouts.Add(about);
            context.SaveChanges();

            return RedirectToAction("Index", "AdminAbout");
        }
    }
}