using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
using System.Data.Entity;
using System.Web.UI;
using System.Drawing.Printing;

namespace TravelTripProject.Controllers

{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();

        public ActionResult Index(int page = 1)
        {
            int pageSize = 4;

            var blogs = context.Blogs
                               .OrderByDescending(g => g.Id)
                               .Skip((page - 1) * pageSize)
                               .Take(pageSize)
                               .ToList();

            int totalBlog = context.Blogs.Count();
            int totalPages = totalBlog / pageSize + (totalBlog % pageSize > 0 ? 1 : 0);

            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;

            return View(blogs);
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
        public ActionResult BlogDetails(int id)
        {
            
            var value = context.Blogs.Include(x => x.Comments).FirstOrDefault(x => x.Id == id);
            var commentsCount = value.Comments.Count();
            ViewBag.commentsCount = commentsCount;
            return View(value);
        }

        [HttpPost]
        public ActionResult BlogDetails(Comment comment)
        {
            if (ModelState.IsValid)
            {
                context.Comments.Add(comment);
                context.SaveChanges();
                return RedirectToAction("BlogDetails", new {id = comment.BlogId});
            }
            return View(comment);
        }

    }
}