using WeaponShop.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

public class WeaponService : IWeaponService
{
    private readonly ShopContext _context;

    public WeaponService(ShopContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Weapon>> GetAllWeaponsAsync()
    {
        return await _context.Weapons.ToListAsync();
    }

    public async Task<Weapon> GetWeaponByIdAsync(int id)
    {
        return await _context.Weapons.FindAsync(id);
    }

    public async Task AddWeaponAsync(Weapon weapon)
    {
        _context.Weapons.Add(weapon);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateWeaponAsync(int id, Weapon weapon)
    {
        _context.Entry(weapon).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteWeaponAsync(int id)
    {
        var weapon = await _context.Weapons.FindAsync(id);
        if (weapon != null)
        {
            _context.Weapons.Remove(weapon);
            await _context.SaveChangesAsync();
        }
    }
}