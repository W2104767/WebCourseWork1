using System.Collections.Generic;

namespace WeaponShop.DTOs
{
    // this model is to represent the categories the weapons belong in
    public class ManufacturerDTO
    {
        public int Id{ get; set; }
        public string Name {get; set;}
        public string Description{ get; set; }

         public List <WeaponDTO>? Weapons { get; set; }  
    }
}