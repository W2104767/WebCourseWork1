using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeaponShop.Models;

namespace WeaponShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedWeaponsController : ControllerBase
    {
        private readonly ShopContext _context;

        public OrderedWeaponsController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/OrderedWeapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderedWeapon>>> GetOrderItems()
        {
            return await _context.OrderItems.ToListAsync();
        }

        // GET: api/OrderedWeapons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderedWeapon>> GetOrderedWeapon(int id)
        {
            var orderedWeapon = await _context.OrderItems.FindAsync(id);

            if (orderedWeapon == null)
            {
                return NotFound();
            }

            return orderedWeapon;
        }

        // PUT: api/OrderedWeapons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderedWeapon(int id, OrderedWeapon orderedWeapon)
        {
            if (id != orderedWeapon.Id)
            {
                return BadRequest();
            }

            _context.Entry(orderedWeapon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderedWeaponExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderedWeapons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderedWeapon>> PostOrderedWeapon(OrderedWeapon orderedWeapon)
        {
            _context.OrderItems.Add(orderedWeapon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderedWeapon", new { id = orderedWeapon.Id }, orderedWeapon);
        }

        // DELETE: api/OrderedWeapons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderedWeapon(int id)
        {
            var orderedWeapon = await _context.OrderItems.FindAsync(id);
            if (orderedWeapon == null)
            {
                return NotFound();
            }

            _context.OrderItems.Remove(orderedWeapon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderedWeaponExists(int id)
        {
            return _context.OrderItems.Any(e => e.Id == id);
        }
    }
}
