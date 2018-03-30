namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeSecurityCodeRequiredAtUserTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "SecurityCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "SecurityCode", c => c.String());
        }
    }
}
