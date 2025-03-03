using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WeaponShop.Models
{
    // this model is to represent the categories the weapons belong in
    public class Order
    {
        
        public int OrderId { get ; set; }
        [Required]
        public int CustomerId{ get ; set; } // Forign key
        [Required]
        public DateTime OrderDate {get ; set;}
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than zero.")]
        public double TotalAmount{ get ; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Status { get ; set; }

        [JsonIgnore]
        public Customer Customer { get ; set; }

    
    // The relationship for oder is that one order belongs to many customers
    }
}