using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    public class House
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string HouseNo { get; set; }
        public string HouseName { get; set; }

        public string Address { get; set; }
        [Required]
        public string OwnerId { get; set; }



    }
}