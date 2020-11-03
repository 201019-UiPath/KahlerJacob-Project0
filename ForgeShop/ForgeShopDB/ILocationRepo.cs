using ForgeShopDB.Models;

namespace ForgeShopDB
{
    public interface ILocationRepo
    {
         Location GetLocationById(int id);
    }
}