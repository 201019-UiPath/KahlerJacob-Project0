using System.Linq;
using ForgeShopDB;
using ForgeShopDB.Models;

namespace ForgeShopLib
{
    public class GetLocationService

    {

        private ILocationRepo repo;
        public Location GetLocation(int id){

            return repo.GetLocationById(id); 
        }
    }
}