using System;
using ForgeShopDB.Models;

namespace ForgeShopUI
{
    public class ExistingCustomerMenu 
    {
        private BrowseInventoryMenu Browse;
        public Cart cart;
        public void start(int userID)
        {   
            string userChoice;
            do{

                
                Console.WriteLine("Which Store would you like to browse?\n [0] North\n [1] South\n [2] East\n [3] West\n [4] Exit");
                userChoice = Console.ReadLine();

                switch(userChoice)
                {

                    case "0":
                        Browse.start(1, userID, cart);
                        break;
                    case "1":
                        Browse.start(2, userID, cart);
                        break;
                    case "2":
                        Browse.start(3, userID, cart);
                        break;
                    case "3":
                        Browse.start(4, userID, cart);
                        break;

                    default:
                        Console.WriteLine("Invalid Entry, Try again");
                        break;
                }

            }while(!userChoice.Equals("4"));
        }
    
    }

}