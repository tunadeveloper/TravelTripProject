using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        
        public PartialViewResult PartialAdminHead()
        {

            return PartialView();
        }

        public PartialViewResult PartialAdminScripts()
        {

            return PartialView();
        }

        public PartialViewResult PartialAdminFooter()
        {
            return PartialView();
        }


        public PartialViewResult PartialAdminSidebar()
        {

            return PartialView();
        }
    }
}