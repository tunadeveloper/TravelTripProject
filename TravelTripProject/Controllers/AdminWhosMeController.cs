using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminWhosMeController : Controller
    {
        // GET: AdminWhosMe
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.whosMes.ToList();
            return View(values);
        }

        public ActionResult UpdateWhosMe(int id)
        {
            var value = context.whosMes.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateWhosMe(WhosMe whosMe)
        {
            var value = context.whosMes.Find(whosMe.Id);
            value.ProfileImage = whosMe.ProfileImage;
            value.Description = whosMe.Description;
            value.PhoneNumber = whosMe.PhoneNumber;
            value.EmailAdress = whosMe.EmailAdress;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminWhosMe");
        }

        public PartialViewResult PartialSocialMedia()
        {
            var values = context.SocialMedias.ToList();
            return PartialView(values);
        }

        public ActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var value = context.SocialMedias.Find(socialMedia.Id);
            value.SocialMediaName = socialMedia.SocialMediaName;
            value.Icon = socialMedia.Icon;
            value.Url = socialMedia.Url;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminWhosMe");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedias.Find(id);
            context.SocialMedias.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminWhosMe");
        }
        public ActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedias.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminWhosMe");
        }
    }
}