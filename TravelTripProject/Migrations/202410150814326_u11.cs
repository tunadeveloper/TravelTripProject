namespace TravelTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class u11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WhosMes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProfileImage = c.String(),
                        Description = c.String(),
                        PhoneNumber = c.String(),
                        EmailAdress = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WhosMes");
        }
    }
}
