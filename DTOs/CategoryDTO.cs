using System.Collections.Generic;

namespace WeaponShop.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<WeaponDTO>? Weapons { get; set; }
    }
}