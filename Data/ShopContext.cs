using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

// The context of the application
using Microsoft.EntityFrameworkCore; // allows the use of DbContext, this is a dependacy more like a framework
using WeaponShop.Models;

namespace WeaponShop.Models
{
    public class ShopContext : IdentityDbContext<IdentityUser>
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedWeapon> OrderItems { get; set; }

      

    }



}