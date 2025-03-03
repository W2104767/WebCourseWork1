
using System.ComponentModel.DataAnnotations;

namespace WeaponShop.DTOs
{
    public class OrderDTO
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; } // Foreign key

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than zero.")]
        public double TotalAmount { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Status { get; set; }
    }
}