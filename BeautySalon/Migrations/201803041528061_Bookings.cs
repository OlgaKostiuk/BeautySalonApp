namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bookings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        BookingDateTime = c.DateTime(nullable: false),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        IsPending = c.Boolean(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "ServiceId", "dbo.Services");
            DropIndex("dbo.Bookings", new[] { "ServiceId" });
            DropTable("dbo.Bookings");
        }
    }
}
