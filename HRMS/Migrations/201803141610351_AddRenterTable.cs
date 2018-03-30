namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRenterTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Renters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Picture = c.String(),
                        IdFront = c.String(),
                        IdBack = c.String(),
                        NumberOfMember = c.Int(nullable: false),
                        MobileNo = c.String(),
                        RentDate = c.DateTime(nullable: false),
                        LeaveDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false),
                        MonthlyRentBill = c.Double(nullable: false),
                        Advance = c.Double(nullable: false),
                        ElectricBill = c.Double(nullable: false),
                        GassBill = c.Double(nullable: false),
                        WaterBill = c.Double(nullable: false),
                        CareTakerBill = c.Double(nullable: false),
                        SecurityManBill = c.Double(nullable: false),
                        ServiceCharge = c.Double(nullable: false),
                        HouseId = c.Int(nullable: false),
                        Owner_Id = c.String(nullable: false),
                        FlatNo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Houses", t => t.HouseId, cascadeDelete: true)
                .Index(t => t.HouseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Renters", "HouseId", "dbo.Houses");
            DropIndex("dbo.Renters", new[] { "HouseId" });
            DropTable("dbo.Renters");
        }
    }
}
