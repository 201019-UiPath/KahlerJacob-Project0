using ForgeShopDB;
using ForgeShopDB.Models;
using System;
using ForgeShopLib;
using ForgeShopDB.Entities;

namespace ForgeShopUI
{
    
    public class ExistingCustomerMenu 
    {
        BrowseInventoryMenu Browse ;
        public Cart cart;
        private ICustomerRepo repo;

        public ExistingCustomerMenu(DBContext context, IMapper mapper)
        {
            this.Browse = new BrowseInventoryMenu(new DBRepo(context,mapper));
           // this.ExistingCustomer = new ExistingCustomerMenu(new DBRepo(context,mapper));
        }
        public ExistingCustomerMenu(ICustomerRepo repo)
        {
            this.repo = repo;
        }
        public void start(int userID)
        {   
            string userInput;
            do{

                
                Console.WriteLine("Which Store would you like to browse?\n [0] North\n [1] South\n [2] East\n [3] West\n [4] Exit");
                userInput = Console.ReadLine();

                switch(userInput)
                {

                    case "0":
                        int table = 1;
                        Browse.start(table, userID);
                        break;
                    case "1":
                        int table2 = 2;
                        Browse.start(table2, userID);
                        break;
                    case "2":
                        int table3 = 3;
                        Browse.start(table3, userID);
                        break;
                    case "3":
                        int table4 = 4;
                        Browse.start(table4, userID);
                        break;

                    default:
                        Console.WriteLine("Invalid Entry, Try again");
                        break;
                }

            }while(!userInput.Equals("4"));
        }
    
    }

}