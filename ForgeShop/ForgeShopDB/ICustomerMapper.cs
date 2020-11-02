using ForgeShopDB.Models;
using ForgeShopDB.Entities;
using System.Collections.Generic;
namespace ForgeShopDB
{
    public interface ICustomerMapper

    {
         Models.Customer ParseCustomer(Entities.Customer customer);

         Entities.Customer ParseCustomer(Models.Customer customer);
         



    }
}