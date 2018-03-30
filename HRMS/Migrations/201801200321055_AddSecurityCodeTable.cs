namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSecurityCodeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SecurityCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Flag = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SecurityCodes");
        }
    }
}
