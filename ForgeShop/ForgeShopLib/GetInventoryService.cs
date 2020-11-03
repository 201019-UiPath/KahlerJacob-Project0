using ForgeShopDB;
using ForgeShopDB.Models;
namespace ForgeShopLib
{
    public class GetInventoryService
    {
        private IInventoryRepo repo;
        public Inventory GetInventory(int id){

            return repo.GetInventorybyStoreID(id); 
        }
    }
}