using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class RentDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Renter")]


        public int RenterId { get; set; }
        public virtual Renter Renter { get; set; }

        public string MonthlyRentBill { get; set; }
        public string Advance { get; set; }
        public string ElectricBill { get; set; }
        public string GassBill { get; set; }
        public string WaterBill { get; set; }
        public string CareTakerBill { get; set; }
        public string SecurityManBill { get; set; }
        public string ServiceCharge { get; set; }
    }
}