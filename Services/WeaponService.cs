using WeaponShop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IWeaponService
{
    Task<IEnumerable<Weapon>> GetAllWeaponsAsync();  // Get all weapons
    Task<Weapon> GetWeaponByIdAsync(int id);  // Get weapon by its ID
    Task AddWeaponAsync(Weapon weapon);  // Add a new weapon
    Task UpdateWeaponAsync(int id, Weapon weapon);  // Update an existing weapon
    Task DeleteWeaponAsync(int id);  // Delete a weapon by ID
}