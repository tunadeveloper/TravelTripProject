using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        // GET: Contect
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(Message message)
        {
            if (ModelState.IsValid)
            {
                message.CreatedDate = DateTime.Now.ToString("dd.MM.yyyy");
                context.messages.Add(message);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(message);
        }
    }
}