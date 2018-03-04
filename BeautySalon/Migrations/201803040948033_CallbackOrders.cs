namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CallbackOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CallbackOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        IsPending = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CallbackOrders");
        }
    }
}
