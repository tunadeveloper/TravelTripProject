using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
using PagedList.Mvc;
namespace TravelTripProject.Controllers
{
    public class AdminGalleryController : Controller
    {
        // GET: GalleryAdmin
        Context context = new Context();
        public ActionResult Index(int page = 1)
        {
            int pageSize = 7;
            var galleries = context.Galleries
                                  .OrderBy(x => x.Id)
                                  .ToPagedList(page, pageSize);

            ViewBag.TotalPages = galleries.PageCount;
            ViewBag.CurrentPage = page;

            return View(galleries);
        }

        public ActionResult UpdateGallery(int id)
        {
            var value = context.Galleries.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateGallery(Gallery gallery)
        {
            var value = context.Galleries.Find(gallery.Id);
            value.Image = gallery.Image;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminGallery");
        }

        public ActionResult DeleteGallery(int id)
        {
            var value = context.Galleries.Find(id);
            context.Galleries.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminGallery");
        }

        public ActionResult CreateImage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateImage(Gallery gallery)
        {
            var value = context.Galleries.Add(gallery);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminGallery");
        }
    }
}