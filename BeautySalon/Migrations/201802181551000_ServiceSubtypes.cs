namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceSubtypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceSubtypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceSubtypes", "ServiceId", "dbo.Services");
            DropIndex("dbo.ServiceSubtypes", new[] { "ServiceId" });
            DropTable("dbo.ServiceSubtypes");
        }
    }
}
