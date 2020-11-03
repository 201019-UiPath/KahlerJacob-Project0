using ForgeShopDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ForgeShopDB
{
    public interface ICustomerRepo
    {
         Customer GetCustomerByID(int id);
         Task<List<Order>> GetAllOrders(int id);
         Task<List<Customer>> GetAllCustomersAsync();
         void AddCustomerAsync(Customer customer);
    }
}