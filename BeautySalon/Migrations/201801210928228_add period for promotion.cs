namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addperiodforpromotion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Promotions", "StartDate", c => c.DateTime());
            AddColumn("dbo.Promotions", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Promotions", "EndDate");
            DropColumn("dbo.Promotions", "StartDate");
        }
    }
}
