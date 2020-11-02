using ForgeShopDB.Models;
using ForgeShopDB.Entities;
namespace ForgeShopDB
{
    public interface IManagerMapper
    {
        Models.Manager ParseManager(Entities.Manager manager);

        Entities.Manager ParseManager(Models.Manager manager);
         
    }
}