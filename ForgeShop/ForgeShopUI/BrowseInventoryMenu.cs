using System;
using ForgeShopDB.Models;
using System.Collections.Generic;
using ForgeShopLib;
using ForgeShopDB.Entities;

namespace ForgeShopUI
{
    public class BrowseInventoryMenu
    {   
        
        public void start(int storeID, int userID, Cart cart)
        {   
            IMenu main = new MainMenu(new DBContext(), new DBMapper());
            ForgeShopDB.Models.Inventory inventory;
            Product prod1;
            Product prod2;
            Product prod3;

            ForgeShopDB.Models.Customer cust;
            ForgeShopDB.Models.Location locale;
            
            //inventory = getInventory(storeID);
            //cust = getCustomer(userID);
            //locale = getLocation(storeID);
            Console.WriteLine($"Welcome to the {locale.name} Location, {cust.fName} {cust.lName}");
            string userChoice;
            string prodChoice;
            do{

                Console.WriteLine("Choose an Item Category\n [0] Hammers\n [1] Aprons\n [2] Anvils\n [3] Exit");
                userChoice = Console.ReadLine();

                switch(userChoice)
                {
                    case "0":
                        //prod1 = getProduct(1);
                        //prod2 = getProduct(2);
                        //prod3 = getProduct(3);

                        Console.WriteLine($"Hammers\n {prod1.name} - ${prod1.price} - {prod1.description} - {inventory.ball} - In Stock");
                        Console.WriteLine($" {prod2.name} - ${prod2.price} - {prod2.description} - {inventory.cross} - In Stock");
                        Console.WriteLine($" {prod3.name} - ${prod3.price} - {prod3.description} - {inventory.flat} - In Stock");
                        break;

                    case "1":
                        //prod1 = getProduct(4);
                        //prod2 = getProduct(5);

                        Console.WriteLine($"Aprons\n {prod1.name} - ${prod1.price} - {prod1.description} - {inventory.apronbrown} - In Stock");
                        Console.WriteLine($" {prod2.name} - ${prod2.price} - {prod2.description} - {inventory.apronblack} - In Stock");
                        break;

                    case "2":
                        //prod1 = getProduct(6);
                        //prod2 = getProduct(7);
                        //prod3 = getProduct(8);

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
                        PurchaseHammer.PurchaseHammer(storeID, userID, inventory, cart);                        
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