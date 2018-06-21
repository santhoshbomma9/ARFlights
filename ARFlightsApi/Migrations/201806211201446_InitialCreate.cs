namespace ARFlightsApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        BookingDate = c.DateTime(nullable: false),
                        Booked = c.Int(nullable: false),
                        HelicopterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Helicopters", t => t.HelicopterId, cascadeDelete: true)
                .Index(t => t.HelicopterId);
            
            CreateTable(
                "dbo.Helicopters",
                c => new
                    {
                        HelicopterId = c.Int(nullable: false, identity: true),
                        HelicopterName = c.String(),
                        Origin = c.String(),
                        Destination = c.String(),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HelicopterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "HelicopterId", "dbo.Helicopters");
            DropIndex("dbo.Bookings", new[] { "HelicopterId" });
            DropTable("dbo.Helicopters");
            DropTable("dbo.Bookings");
        }
    }
}
