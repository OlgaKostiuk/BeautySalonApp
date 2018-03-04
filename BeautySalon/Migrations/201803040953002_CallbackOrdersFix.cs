namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CallbackOrdersFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CallbackOrders", "PhoneNumber", c => c.String());
            DropColumn("dbo.CallbackOrders", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CallbackOrders", "Description", c => c.String());
            DropColumn("dbo.CallbackOrders", "PhoneNumber");
        }
    }
}
