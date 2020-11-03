using System;
using ForgeShopDB.Models;
using System.Collections.Generic;
using ForgeShopLib;
using ForgeShopDB.Entities;
using ForgeShopDB;

namespace ForgeShopUI
{
    public class BrowseInventoryMenu
    { 
        public ICustomerRepo repo;
/*
        public BrowseInventoryMenu(DBContext context, IMapper mapper)
        {
            this.Browse = new BrowseInventoryMenu(new DBRepo(context,mapper));
           // this.ExistingCustomer = new ExistingCustomerMenu(new DBRepo(context,mapper));
        }*/

         public BrowseInventoryMenu(ICustomerRepo repo)
        {
            this.repo = repo;
        }         
        
        public void start(int storeID, int userID)
        {   
            IMenu main = new MainMenu(new DBContext(), new DBMapper());
            ForgeShopDB.Models.Inventory inventory;

            //These are Product Holders
            Product prod1;
            Product prod2;
            Product prod3;

            //These allow me to Call DB Repo to set local variables
            GetLocationService locate = new GetLocationService();
            GetCustomerService findCust = new GetCustomerService();
            GetInventoryService findInv = new GetInventoryService();
            GetProductService getProd = new GetProductService();

            //used to pass model objects
            ForgeShopDB.Models.Customer cust;
            ForgeShopDB.Models.Location locale;
            
            // fills the local models with DB Data
            inventory = findInv.GetInventory(storeID);
            cust = findCust.GetCustomer(userID);
            locale = locate.GetLocation(storeID);

            
            Console.WriteLine($"Welcome to the {locale.name} Location, {cust.fName} {cust.lName}");
            string userChoice;
            string prodChoice;
            //Loop for menu
            do{

                Console.WriteLine("Choose an Item Category\n [0] Hammers\n [1] Aprons\n [2] Anvils\n [3] Exit");
                userChoice = Console.ReadLine();

                switch(userChoice)
                {
                    case "0":
                        //sets the product holders Keyed to the Products table
                        prod1 = getProd.GetProduct(1);
                        prod2 = getProd.GetProduct(2);
                        prod3 = getProd.GetProduct(3);
                        //Displays the Hammer Selction Name, Price, Description, quantity
                        Console.WriteLine($"Hammers\n {prod1.name} - ${prod1.price} - {prod1.description} - {inventory.ball} - In Stock");
                        Console.WriteLine($" {prod2.name} - ${prod2.price} - {prod2.description} - {inventory.cross} - In Stock");
                        Console.WriteLine($" {prod3.name} - ${prod3.price} - {prod3.description} - {inventory.flat} - In Stock");
                        break;

                    case "1":
                        prod1 = getProd.GetProduct(4);
                        prod2 = getProd.GetProduct(5);

                        Console.WriteLine($"Aprons\n {prod1.name} - ${prod1.price} - {prod1.description} - {inventory.apronbrown} - In Stock");
                        Console.WriteLine($" {prod2.name} - ${prod2.price} - {prod2.description} - {inventory.apronblack} - In Stock");
                        break;

                    case "2":
                        prod1 = getProd.GetProduct(6);
                        prod2 = getProd.GetProduct(7);
                        prod3 = getProd.GetProduct(8);

                        Console.WriteLine($"Anvils\n {prod1.name} - ${prod1.price} - {prod1.description} - {inventory.anvilsmall} - In Stock");
                        Console.WriteLine($" {prod2.name} - ${prod2.price} - {prod2.description} - {inventory.anvilmed} - In Stock");
                        Console.WriteLine($" {prod3.name} - ${prod3.price} - {prod3.description} - {inventory.anvillarge} - In Stock");

                        break;

                    default:
                        Console.WriteLine("Invalid Entry - Try Again");
                        break;
                }


            }while(!userChoice.Equals("3"));

            do{
                Console.WriteLine("What would you like to do?\n [0] Purchase Hammer\n [1] Purchase Apron\n [2] Purchase Anvil\n [3] Exit");
                userChoice = Console.ReadLine();


                switch(userChoice){
                    case "0":
                        PurchaseHammerMenu PurchaseHammer = new PurchaseHammerMenu();
                        PurchaseHammer.PurchaseHammer(storeID, userID, inventory);                        
                        main.start();
                        break;



                    case "1":
                        Console.WriteLine("Which Apron are you interested in?\n [0] Brown Apron\n [1] Black Apron");
                        prodChoice = Console.ReadLine();
                    break;

                    case "2":
                        Console.WriteLine("Which Anvil are you interested in?\n [0] 20 lb\n [1] 40 lb\n [2] 100 lb");
                        prodChoice = Console.ReadLine();
                    break;

                    default:
                        Console.WriteLine("Invalid Entry - Try Again");
                    break;
                }


            }while(!userChoice.Equals("3"));
        }
    }
}