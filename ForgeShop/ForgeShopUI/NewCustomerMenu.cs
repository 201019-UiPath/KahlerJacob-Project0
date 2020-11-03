using ForgeShopDB;
using ForgeShopDB.Models;
using System;
using ForgeShopLib;
namespace ForgeShopUI
{
    public class NewCustomerMenu : IMenu
    {
        private string userChoice;
        private ICustomerRepo repo;
        private NewCustomerService  NewCustomer;
        
        

        public NewCustomerMenu(ICustomerRepo repo)
        {
            this.repo = repo;
            //this.service = service;
           // tasks=new HerosLib.HeroTasks();
            //this.heroService = new HeroService(repo);

       
        }

        public void start()
        {
            Customer newCust = new Customer();
            //enter user name
            Console.WriteLine("Enter a User Name");
            newCust.userName = Console.ReadLine();
            //enter user pin
            Console.WriteLine("Enter a Pin/Password");
            newCust.pin = Console.ReadLine();
            //enter Fname
            Console.WriteLine("Enter Your First Name");
            newCust.fName = Console.ReadLine();
            //enter Lname
            Console.WriteLine("Enter Your Last Name");
            newCust.lName = Console.ReadLine();
            //enter Email
            Console.WriteLine("Enter E-Mail");
            newCust.eMail = Console.ReadLine();
            //enter Address
            Console.WriteLine("Enter Your House Number");
            newCust.address = Console.ReadLine();
            //enter Street
            Console.WriteLine("Enter Your Street");
            newCust.street = Console.ReadLine();
            //enter City
            Console.WriteLine("Enter Your City");
            newCust.city = Console.ReadLine();
            //enter State
            Console.WriteLine("Enter Your State");
            newCust.state = Console.ReadLine();
            //enter Zipcode
            Console.WriteLine("Enter Your Zip Code");
            newCust.zipCode = Console.ReadLine();

            NewCustomer.AddCustomer(newCust);
        }
    }
}