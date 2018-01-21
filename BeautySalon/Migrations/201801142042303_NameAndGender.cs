namespace BeautySalon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameAndGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
