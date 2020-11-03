using ForgeShopDB;
using ForgeShopDB.Models;

namespace ForgeShopLib
{
    public class GetCustomerService
    {
        private ICustomerRepo repo;

        public Customer GetCustomer(int id)
        {
            return repo.GetCustomerByID(id);
        }
    }
}