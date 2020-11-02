using ForgeShopDB.Models;
using ForgeShopDB.Entities;
using System.Collections.Generic;
namespace ForgeShopDB
{
    public interface IOrdermapper

    {
        Order ParseOrder(Orders orders);
        Orders ParseOrder(Order order);
    }
}