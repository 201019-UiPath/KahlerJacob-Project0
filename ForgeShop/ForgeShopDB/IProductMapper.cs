using ForgeShopDB.Models;
using ForgeShopDB.Entities;

namespace ForgeShopDB
{
    public interface IProductMapper
    {
        Product ParseProduct(Products products);

        Products ParseProduct(Product product);
    }
}