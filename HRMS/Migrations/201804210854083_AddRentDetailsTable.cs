namespace HRMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentDetailsTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Renters", "MonthlyRentBill");
            DropColumn("dbo.Renters", "Advance");
            DropColumn("dbo.Renters", "ElectricBill");
            DropColumn("dbo.Renters", "GassBill");
            DropColumn("dbo.Renters", "WaterBill");
            DropColumn("dbo.Renters", "CareTakerBill");
            DropColumn("dbo.Renters", "SecurityManBill");
            DropColumn("dbo.Renters", "ServiceCharge");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Renters", "ServiceCharge", c => c.String());
            AddColumn("dbo.Renters", "SecurityManBill", c => c.String());
            AddColumn("dbo.Renters", "CareTakerBill", c => c.String());
            AddColumn("dbo.Renters", "WaterBill", c => c.String());
            AddColumn("dbo.Renters", "GassBill", c => c.String());
            AddColumn("dbo.Renters", "ElectricBill", c => c.String());
            AddColumn("dbo.Renters", "Advance", c => c.String());
            AddColumn("dbo.Renters", "MonthlyRentBill", c => c.String());
        }
    }
}
