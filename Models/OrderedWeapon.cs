using System.Collections.Generic;
using System.Text.Json.Serialization;


// this Model is the join table that manaages the many to many relationship between Oreder and Weapon


namespace WeaponShop.Models
{
    public class OrderedWeapon
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice{ get; set; }

        public int OrderId {get; set;} // forign key
        public int WeaponId { get; set; }// forign key

        [JsonIgnore]
        public Order Order {get; set;}
        [JsonIgnore]
        public Weapon Weapon {get; set;}

    }








}
