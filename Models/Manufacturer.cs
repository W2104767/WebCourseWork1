using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace WeaponShop.Models
{
    // this model is to represent the categories the weapons belong in
    public class Manufacturer
    {
        public int Id{ get; set; }
        public string Name {get; set;}
        public string Description{ get; set; }
    
    // The relationship for Manufactuerer is that one Manufacturer can make many weapons
         
         [JsonIgnore]
         public List <Weapon>? Weapons { get; set; }  
    }
}