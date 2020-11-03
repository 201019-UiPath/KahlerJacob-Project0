using ForgeShopDB;
using ForgeShopDB.Models;
namespace ForgeShopLib
{
    public class GetProductService
    {
        private IProductRepo repo;
        public Product GetProduct(int id){

            return repo.GetProductById(id); 
        }
    }
}