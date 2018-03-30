using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRMS.Models
{
    public class Renter
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }
        public string IdFront { get; set; }
        public string IdBack { get; set; }
        public int NumberOfMember { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }

        public string RentDate { get; set; }
        public string LeaveDate { get; set; }
        [Required]
        public string Status { get; set; }




        public string MonthlyRentBill { get; set; }
        public string Advance { get; set; }
        public string ElectricBill { get; set; }
        public string GassBill { get; set; }
        public string WaterBill { get; set; }
        public string CareTakerBill { get; set; }
        public string SecurityManBill { get; set; }
        public string ServiceCharge { get; set; }

       


        [ForeignKey("House")]


        public int HouseId { get; set; }
        public virtual House House { get; set; }

        
        public string Owner_Id { get; set; }

      [Required]
        public string FlatNo { get; set; }




    }
}