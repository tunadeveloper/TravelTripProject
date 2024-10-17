using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    
    public class DefaultController : Controller
    {
        Context context = new Context();
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            var randomGalleries = context.Galleries
                                   .OrderBy(r => Guid.NewGuid()) 
                                   .Take(6) 
                                   .ToList();

            return PartialView(randomGalleries);
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}