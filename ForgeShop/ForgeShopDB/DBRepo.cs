using System.Collections.Generic;
using System.Threading.Tasks;
using ForgeShopDB.Models;
using ForgeShopDB.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ForgeShopDB
{
    public class DBRepo : ICustomerRepo
    {
        private readonly DBContext context;
        private readonly IMapper mapper;

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

        public Models.Customer GetCustomerByUser(string user)
        {
            throw new System.NotImplementedException();
        }
    }
}