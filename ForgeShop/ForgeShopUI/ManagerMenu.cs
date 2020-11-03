using System;

namespace ForgeShopUI
{
    public class ManagerMenu : IMenu
    {
        public void start()
        {
            string userChoice;
            

            

            do{
                Console.WriteLine("Welcome Manager - Which store do you manage?\n [0] North\n [1] South\n [2] East\n [3] West\n [4] Exit");
                userChoice = Console.ReadLine();

                switch(userChoice)
                {
                    case "0":
                    // call StoreManageMenu sending id 1
                    break;

                    case "1":
                    // call StoreManageMenu sending id 2
                    break;

                    case "2":
                    // call StoreManageMenu sending id 3
                    break;

                    case "3":
                    // call StoreManageMenu sending id 4
                    break;

                    default:
                    Console.WriteLine("Invalid Entry, Try Again");
                    break;
                }
            }while(!(userChoice.Equals("4")));
            

        }
    }
}