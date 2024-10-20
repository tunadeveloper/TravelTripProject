﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
using PagedList;
using PagedList.Mvc;
using System.Xml.Linq;
namespace TravelTripProject.Controllers
{
    public class AdminBlogController : Controller
    {
        // GET: AdminBlog
        Context context = new Context();
        public ActionResult Index(int page =1)
        {
            int pageSize = 7;
            var values = context.Blogs
                .OrderByDescending(x => x.Id)
                .ToPagedList(page, pageSize);

            ViewBag.TotalPages = values.PageCount;
            ViewBag.CurrentPage = page;
            return View(values);
        }

        public ActionResult DeleteBlog(int id)
        {
            var value = context.Blogs.Find(id);
            context.Blogs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminBlog");
        }

        public ActionResult UpdateBlog(int id)
        {
            var value = context.Blogs.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var value = context.Blogs.Find(blog.Id);
            value.Title = blog.Title;
            value.Description = blog.Description;
            value.Image = blog.Image;
            value.City = blog.City;
            value.Date = DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("Index", "AdminBlog");
        }

        public ActionResult CreateBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBlog(Blog blog)
        {
            blog.Date = DateTime.Now;
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index", "AdminBlog");
        }
    }
}