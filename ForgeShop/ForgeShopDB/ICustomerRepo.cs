using ForgeShopDB.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace ForgeShopDB
{
    public interface ICustomerRepo
    {
         Customer GetCustomerByUser(string user);
         Task<List<Order>> GetAllOrders(int id);
         Task<List<Customer>> GetAllCustomersAsync();
         void AddCustomerAsync(Customer customer);
    }
}