using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
using PagedList;
using PagedList.Mvc;
namespace TravelTripProject.Controllers

{
    public class AdminCommentController : Controller
    {
        // GET: Comment
        Context context = new Context();
        public ActionResult Index(int page = 1)
        {
            int pageSize = 8;
            var comments = context.Comments
                                  .OrderByDescending(x => x.Id)
                                  .ToPagedList(page, pageSize);

            ViewBag.TotalPages = comments.PageCount; 
            ViewBag.CurrentPage = page;

            return View(comments);
        }





        public PartialViewResult CommentPaged()
        {
            return PartialView();
        }



        public ActionResult DeleteComment(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminComment");
        }
    }
}