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
    public class WeaponsController : ControllerBase
    {
        private readonly IWeaponService _weaponService;
        private readonly ILogger<WeaponsController> _logger;

        public WeaponsController(IWeaponService weaponService, ILogger<WeaponsController> logger)
        {
            _weaponService = weaponService;
            _logger = logger;
        }

        // GET: api/Weapons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Weapon>>> GetWeapons()
        {
            try
            {
                _logger.LogInformation("Fetching all weapons.");
                var weapons = await _weaponService.GetAllWeaponsAsync();
                if (weapons == null || !weapons.Any())
                {
                    _logger.LogWarning("No weapons found.");
                    return NotFound("No weapons found.");
                }
                return Ok(weapons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching weapons.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // GET: api/Weapons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Weapon>> GetWeapon(int id)
        {
            try
            {
                _logger.LogInformation($"Fetching weapon with ID {id}");
                var weapon = await _weaponService.GetWeaponByIdAsync(id);
                if (weapon == null)
                {
                    _logger.LogWarning($"Weapon with ID {id} not found.");
                    return NotFound($"Weapon with ID {id} not found.");
                }
                return Ok(weapon);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the weapon.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // PUT: api/Weapons/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWeapon(int id, Weapon weapon)
        {
            try
            {
                if (id != weapon.Id)
                {
                    _logger.LogWarning("Weapon ID mismatch.");
                    return BadRequest("Weapon ID mismatch.");
                }
                await _weaponService.UpdateWeaponAsync(id, weapon);
                _logger.LogInformation($"Weapon with ID {id} updated.");
                return NoContent();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (await _weaponService.GetWeaponByIdAsync(id) == null)
                {
                    _logger.LogWarning($"Weapon with ID {id} not found for update.");
                    return NotFound($"Weapon with ID {id} not found.");
                }
                else
                {
                    _logger.LogError("Error updating weapon.");
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the weapon.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // POST: api/Weapons
        [HttpPost]
        public async Task<ActionResult<Weapon>> PostWeapon(Weapon weapon)
        {
            try
            {
                if (weapon == null)
                {
                    _logger.LogWarning("Received empty weapon object.");
                    return BadRequest("Weapon data cannot be null.");
                }
                await _weaponService.AddWeaponAsync(weapon);
                _logger.LogInformation($"Weapon with ID {weapon.Id} created.");
                return CreatedAtAction("GetWeapon", new { id = weapon.Id }, weapon);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the weapon.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }

        // DELETE: api/Weapons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWeapon(int id)
        {
            try
            {
                var weapon = await _weaponService.GetWeaponByIdAsync(id);
                if (weapon == null)
                {
                    _logger.LogWarning($"Weapon with ID {id} not found.");
                    return NotFound($"Weapon with ID {id} not found.");
                }
                await _weaponService.DeleteWeaponAsync(id);
                _logger.LogInformation($"Weapon with ID {id} deleted.");
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the weapon.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error");
            }
        }
    }
}
