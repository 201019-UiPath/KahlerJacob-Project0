using System.Collections.Generic;
using ForgeShopDB.Models;
namespace ForgeShopLib
{
    public class AddToCartService
    {

        public void AddToCart(int storeID, int custID, Inventory inventory, Cart cart, int Qnty, int ProductID)

        {
            //will check the Qnty against the amount in the Inventory table referenced by the StoreID
            //will push to cart stack if succeed
            //will reduce the Inventory amount in that inventory table

        }
        
    }
}