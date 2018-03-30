namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSomePropertyToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false, maxLength: 70));
            AddColumn("dbo.AspNetUsers", "Mobile", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.AspNetUsers", "SecurityCode", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "SecurityCode");
            DropColumn("dbo.AspNetUsers", "Mobile");
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
