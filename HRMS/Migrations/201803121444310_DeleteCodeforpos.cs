namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCodeforpos : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ProductCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
