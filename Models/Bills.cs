using System.ComponentModel.DataAnnotations;

namespace TransportModule1.Models
{
    public class Bills
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [Required]
        public DateTime LrDate { get; set; } // Changed to DateTime

        [Required]
        public string LrNo { get; set; }
        [Required]
        public string VehicleType { get; set; }

        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        public string VehicleNo { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Freight { get; set; } // Changed to decimal

        public string Others { get; set; }
    }
}
