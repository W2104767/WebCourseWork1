using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
namespace WeaponShop.Models
{
    // this model is for the weapons that will be available in the shop
    public class Weapon
    {
        public int Id{ get; set; } // primary key 
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name {get; set;}
        
        [Required]  
        [Range(0.01, double.MaxValue)]

        public double Price{ get; set; }
        [Required]  
        [Range(0, int.MaxValue)]
        public int StockQuantity{ get; set; }
        //these two properties are the forign keys
        [Required]
        public int CategoryId { get; set; } // Foreign key that shows one to many relationship  
        [Required]
        public int ManufacturerId{ get; set; } //Foreign key that shows one to many relationship
        
        [JsonIgnore]
        public Category Category { get ; set; } 
        [JsonIgnore]
        public Manufacturer Manufacturer { get; set; } 

    
    
    }




}