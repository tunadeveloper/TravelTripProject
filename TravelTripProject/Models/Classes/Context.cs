using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelTripProject.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<WhosMe> whosMes { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Message> messages { get; set; }
    }
}