namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "CreatedDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "CreatedDate");
        }
    }
}
