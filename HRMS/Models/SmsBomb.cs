using System.ComponentModel.DataAnnotations;

namespace HRMS.Models
{
    public class SmsBomb
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }
        public string Message { get; set; }

        public string Size { get; set; }
    }
}