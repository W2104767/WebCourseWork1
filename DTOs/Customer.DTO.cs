using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace WeaponShop.DTOs
{
    // this model is to represent the customers that may pruchase a weapon(s)
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 3)] // data annotations
        public string FirstName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Email { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string PostCode { get; set; }
        public List<OrderDTO>? Orders { get; set; }

    }
}