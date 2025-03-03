using System.Collections.Generic;


namespace WeaponShop.DTOs
{
    public class OrderedWeaponDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int OrderId { get; set; }
        public int WeaponId { get; set; }
    }
}