using ForgeShopDB.Models;
using System;
using ForgeShopLib;

namespace ForgeShopUI
{
    public class PurchaseHammerMenu
    {
        public void PurchaseHammer(int storeID, int custID, Inventory inventory)
        {
            string prodChoice;
            string Quantity;
            int NumQty = 0;

            Console.WriteLine("Stop! HammerTIME!\nWhich Hammer are you interested in?\n [0] Ball Hammer\n [1] Cross Face Hammer\n [2] Flat Face Hammer");
            prodChoice = Console.ReadLine();
                        
            switch(prodChoice)
            {

                case "0":
                                
                    Console.WriteLine("How many?");
                    Quantity = Console.ReadLine();
                    try
                    {
                        NumQty = Convert.ToInt32(Quantity);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input string is not a number.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("The number is way too large");
                    }
                    AddToCartService AddCart = new AddToCartService();
                    AddCart.AddToCart(storeID, custID, inventory, NumQty, 1);


                break;

                case "1":
                                
                Console.WriteLine("How many?");
                Quantity = Console.ReadLine();
                break;

                case "2":
                                
                Console.WriteLine("How many?");
                Quantity = Console.ReadLine();
                break;

            }

        }
    }
}