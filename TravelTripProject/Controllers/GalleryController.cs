using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    [AllowAnonymous]
    public class GalleryController : Controller
    {
        // GET: Gallery
        Context context = new Context();
        public ActionResult Index(int page = 1)
        {
            int pageSize = 6;
            var galleries = context.Galleries
                                   .OrderByDescending(g => g.Id)
                                   .Skip((page - 1) * pageSize)
                                   .Take(pageSize)
                                   .ToList();

            int totalGalleries = context.Galleries.Count();
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalGalleries / pageSize);
            ViewBag.CurrentPage = page;

            return View(galleries);
        }


    }
}