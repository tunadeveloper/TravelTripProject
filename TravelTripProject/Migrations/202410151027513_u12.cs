namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Image = c.String(),
                        ImageDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SocialMediaName = c.String(),
                        Icon = c.String(),
                        Url = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Homes", "ContentImage");
            DropColumn("dbo.Homes", "ContentImageDescription");
            DropColumn("dbo.Homes", "SidebarImage");
            DropColumn("dbo.Homes", "SidebarWhosMe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Homes", "SidebarWhosMe", c => c.String());
            AddColumn("dbo.Homes", "SidebarImage", c => c.String());
            AddColumn("dbo.Homes", "ContentImageDescription", c => c.String());
            AddColumn("dbo.Homes", "ContentImage", c => c.String());
            DropTable("dbo.SocialMedias");
            DropTable("dbo.Galleries");
            DropTable("dbo.Contents");
        }
    }
}
