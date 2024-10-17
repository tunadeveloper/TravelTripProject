namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Blog_Id", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "Blog_Id" });
            RenameColumn(table: "dbo.Comments", name: "Blog_Id", newName: "BlogId");
            AlterColumn("dbo.Comments", "BlogId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "BlogId");
            AddForeignKey("dbo.Comments", "BlogId", "dbo.Blogs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Comments", new[] { "BlogId" });
            AlterColumn("dbo.Comments", "BlogId", c => c.Int());
            RenameColumn(table: "dbo.Comments", name: "BlogId", newName: "Blog_Id");
            CreateIndex("dbo.Comments", "Blog_Id");
            AddForeignKey("dbo.Comments", "Blog_Id", "dbo.Blogs", "Id");
        }
    }
}
