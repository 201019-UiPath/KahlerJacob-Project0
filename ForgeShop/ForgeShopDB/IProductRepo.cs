using ForgeShopDB.Models;
namespace ForgeShopDB
{
    public interface IProductRepo
    {
         Product GetProductById(int id);
    }
}