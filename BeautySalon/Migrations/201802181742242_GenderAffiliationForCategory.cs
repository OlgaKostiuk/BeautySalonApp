namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenderAffiliationForCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ServiceCategories", "GenderAffiliation", c => c.String());
            DropColumn("dbo.ServiceCategories", "Description");
            DropColumn("dbo.Services", "ClientGender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "ClientGender", c => c.String());
            AddColumn("dbo.ServiceCategories", "Description", c => c.String());
            DropColumn("dbo.ServiceCategories", "GenderAffiliation");
        }
    }
}
