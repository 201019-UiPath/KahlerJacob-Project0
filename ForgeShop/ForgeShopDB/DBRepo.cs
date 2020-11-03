using System.Collections.Generic;
using System.Threading.Tasks;
using ForgeShopDB.Models;
using ForgeShopDB.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ForgeShopDB
{
    public class DBRepo : ICustomerRepo, ILocationRepo, IInventoryRepo
    {
        public DBContext context;
        public IMapper mapper;
        public Models.Inventory GetInventorybyStoreID(int id)
        {
            return  (Models.Inventory) context.Inventory.Where(x => x.Storeid == id);
        }

       
    



        public DBRepo(DBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }



        public void AddCustomerAsync(Models.Customer customer)
        {
            context.Customer.AddAsync(mapper.ParseCustomer(customer));
            context.SaveChangesAsync();
        }

        public Task<List<Models.Customer>> GetAllCustomersAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Order>> GetAllOrders(int id)
        {
            throw new System.NotImplementedException();
        }

        public Models.Customer GetCustomerByID(int id)
        {
            return (Models.Customer) context.Customer.Where(x => x.Id == id);
        }

        public Models.Location GetLocationById(int id)
        {
            return  (Models.Location) context.Location.Where(x => x.Id == id);
        }
    }
}