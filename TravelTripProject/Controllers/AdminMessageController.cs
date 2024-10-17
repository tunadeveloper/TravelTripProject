using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminMessageController : Controller
    {
        // GET: AdminMessage
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.messages.OrderByDescending(x=>x.Id).ToList();
            return View(values);
        }

        public ActionResult MessageDetails(int id)
        {
            var value = context.messages.Where(x=>x.Id == id).ToList();
            return View(value);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = context.messages.Find(id);
            context.messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminMessage");
        }
    }
}