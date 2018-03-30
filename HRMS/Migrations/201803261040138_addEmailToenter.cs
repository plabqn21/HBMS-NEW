namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmailToenter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Renters", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Renters", "Email");
        }
    }
}
