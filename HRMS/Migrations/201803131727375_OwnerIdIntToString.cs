namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OwnerIdIntToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Houses", "OwnerId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Houses", "OwnerId", c => c.Int(nullable: false));
        }
    }
}
