using WeaponShop.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
public interface ICustomerService
{
Task<IEnumerable<Customer>> GetAllCustomersAsync();
Task<Customer> GetCustomerByIdAsync(int id);
Task AddCustomerAsync(Customer customer);
Task UpdateCustomerAsync(int id, Customer customer);
Task DeleteCustomerAsync(int id);
}