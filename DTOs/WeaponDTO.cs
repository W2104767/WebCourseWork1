using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeaponShop.DTOs
{
    public class WeaponDTO
    {
         public int Id { get; set; }
         [Required]
        [StringLength(100, MinimumLength = 3)]
         public string Name {get; set;}
      
        [Required]  
        [Range(0.01, double.MaxValue)]
        public double Price{ get; set; }
        
        [Required]  
        [Range(0, int.MaxValue)] 
        public int StockQuantity{ get; set; }
        
         [Required] 
        public int CategoryId { get; set; } 
         [Required] 
        public int ManufacturerId{ get; set; } 


    }

    



}