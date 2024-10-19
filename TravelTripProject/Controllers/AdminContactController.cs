using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminContactController : Controller
    {
        // GET: AdminContact
        Context context = new Context();
        public ActionResult Index()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
        public ActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(Contact contact)
        {
            var value = context.Contacts.Find(contact.Id);
            value.Description = contact.Description;
            value.Map = contact.Map;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminContact");
        }
    }
}