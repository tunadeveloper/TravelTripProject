using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminHomeController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Homes.ToList();
            return View(values);
        }

        public ActionResult UpdateHome(int id)
        {
            var value = context.Homes.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateHome(Home home)
        {
            var value = context.Homes.Find(home.Id);
            value.HeadImageTitle = home.HeadImageTitle;
            value.HeadImageDescription = home.HeadImageDescription;
            value.HeadImage = home.HeadImage;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminHome");
        }

        public PartialViewResult PartialContentImage()
        {
            var values = context.Contents.ToList();
            return PartialView(values);
        }

        public ActionResult UpdateContentImage(int id)
        {
            var value = context.Contents.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContentImage(Content content)
        {
            var value = context.Contents.Find(content.Id);
            value.Image = content.Image;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminHome");
        }

        public ActionResult DeleteContentImage(int id)
        {
            var value = context.Contents.Find(id);
            context.Contents.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminHome");
        }

        public ActionResult CreateContentImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContentImage(Content content)
        {
            var value = context.Contents.Add(content);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminHome");
        }
    }
}