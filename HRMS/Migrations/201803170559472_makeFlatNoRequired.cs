namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class makeFlatNoRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Renters", "FlatNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Renters", "FlatNo", c => c.String());
        }
    }
}
