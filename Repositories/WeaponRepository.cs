using WeaponShop.Models;
using Microsoft.EntityFrameworkCore;
namespace WeaponShop.Repositories

{
    public class WeaponRepository
    {
        private readonly ShopContext _context;

        public WeaponRepository(ShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Weapon>> GetAllAsync() => await _context.Weapons.ToListAsync();

        public async Task<Weapon> GetByIdAsync(int id) => await _context.Weapons.FindAsync(id);

        public async Task AddAsync(Weapon weapon)
        {
            _context.Weapons.Add(weapon);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Weapon weapon)
        {
            _context.Entry(weapon).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var weapon = await _context.Weapons.FindAsync(id);
            if (weapon != null)
            {
                _context.Weapons.Remove(weapon);
                await _context.SaveChangesAsync();
            }
        }
    }
}