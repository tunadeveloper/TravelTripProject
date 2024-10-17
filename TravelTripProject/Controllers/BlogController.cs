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
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();

        public ActionResult Index(int page = 1)
        {
            int pageSize = 4; 

            var blogs = context.Blogs
                                   .OrderBy(g => g.Id) 
                                   .Skip((page - 1) * pageSize) 
                                   .Take(pageSize) 
                                   .ToList();
            int totalBlog = context.Blogs.Count();

            ViewBag.TotalPages = (int)Math.Ceiling((double)totalBlog / pageSize);
            ViewBag.CurrentPage = page;

            var values = context.Blogs.OrderByDescending(x => x.Id).ToList();

            var commentsCount = context.Comments.Count();
            ViewBag.commentsCount = commentsCount;

            ViewBag.Galleries = blogs; 

            return View(values);
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