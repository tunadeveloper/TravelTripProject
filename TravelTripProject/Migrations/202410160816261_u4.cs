namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Map", c => c.String());
            DropColumn("dbo.Contacts", "Image");
            DropColumn("dbo.Contacts", "NameSurname");
            DropColumn("dbo.Contacts", "Email");
            DropColumn("dbo.Contacts", "Phone");
            DropColumn("dbo.Contacts", "Message");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Message", c => c.String());
            AddColumn("dbo.Contacts", "Phone", c => c.String());
            AddColumn("dbo.Contacts", "Email", c => c.String());
            AddColumn("dbo.Contacts", "NameSurname", c => c.String());
            AddColumn("dbo.Contacts", "Image", c => c.String());
            DropColumn("dbo.Contacts", "Map");
        }
    }
}
