namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeChangedToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Renters", "RentDate", c => c.String());
            AlterColumn("dbo.Renters", "LeaveDate", c => c.String());
            AlterColumn("dbo.Renters", "MonthlyRentBill", c => c.String());
            AlterColumn("dbo.Renters", "Advance", c => c.String());
            AlterColumn("dbo.Renters", "ElectricBill", c => c.String());
            AlterColumn("dbo.Renters", "GassBill", c => c.String());
            AlterColumn("dbo.Renters", "WaterBill", c => c.String());
            AlterColumn("dbo.Renters", "CareTakerBill", c => c.String());
            AlterColumn("dbo.Renters", "SecurityManBill", c => c.String());
            AlterColumn("dbo.Renters", "ServiceCharge", c => c.String());
            AlterColumn("dbo.Renters", "Owner_Id", c => c.String());
            AlterColumn("dbo.Renters", "FlatNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Renters", "FlatNo", c => c.String(nullable: false));
            AlterColumn("dbo.Renters", "Owner_Id", c => c.String(nullable: false));
            AlterColumn("dbo.Renters", "ServiceCharge", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "SecurityManBill", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "CareTakerBill", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "WaterBill", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "GassBill", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "ElectricBill", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "Advance", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "MonthlyRentBill", c => c.Double(nullable: false));
            AlterColumn("dbo.Renters", "LeaveDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Renters", "RentDate", c => c.DateTime(nullable: false));
        }
    }
}
