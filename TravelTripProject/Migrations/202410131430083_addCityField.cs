namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCityField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "City");
        }
    }
}
