using ForgeShopDB.Models;
namespace ForgeShopDB
{
    public interface IInventoryRepo
    {
         Inventory GetInventorybyStoreID(int id);
    }
}