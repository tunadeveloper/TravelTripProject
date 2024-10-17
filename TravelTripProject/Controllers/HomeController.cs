using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Default
        Context context = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            HomeBlog viewModel = new HomeBlog();
            viewModel.Homes = context.Homes.ToList();
            viewModel.Blogs = context.Blogs.OrderByDescending(x => x.Id).Take(4).ToList();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(Message message)
        {
            if (ModelState.IsValid) { 
            message.CreatedDate = DateTime.Now.ToString("dd.MM.yyyy");
            context.messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(message);
        }

        public PartialViewResult LatestBlogs()
        {
            var values = context.Blogs.OrderByDescending(x => x.Id).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialWhosMe()
        {
            var value = context.whosMes.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialContent()
        {
            var value = context.Contents.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialSocialMedia()
        {
            var value = context.SocialMedias.ToList();
            return PartialView(value);
        }

        

    }
}