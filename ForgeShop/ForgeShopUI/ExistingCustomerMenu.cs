using System;
using ForgeShopDB.Models;

namespace ForgeShopUI
{
    public class ExistingCustomerMenu : IMenu
    {
        public void start()
        {
            string userName;
            string userPin;

            Console.WriteLine("Please enter your UserName");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your Pin/Password");
            userPin = Console.ReadLine();
            
        }


    }
}