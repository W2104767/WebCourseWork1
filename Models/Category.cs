using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeaponShop.Models
{
    // this model is to represent the categories the weapons belong in
    public class Category
    {
        public int Id{ get; set; }
        public string Name {get; set;}
        public string Description{ get; set; }

     // the relationship for Catergory is that one catergory can have many weapons
        
        [JsonIgnore]
        public List <Weapon>? Weapons { get; set; }  



    
  
    }
    

















}






