namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Promotion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PromotionImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        PromotionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Promotions", t => t.PromotionId, cascadeDelete: true)
                .Index(t => t.PromotionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PromotionImages", "PromotionId", "dbo.Promotions");
            DropIndex("dbo.PromotionImages", new[] { "PromotionId" });
            DropTable("dbo.PromotionImages");
            DropTable("dbo.Promotions");
        }
    }
}
