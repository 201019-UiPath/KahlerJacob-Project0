using System;
using ForgeShopDB;
using ForgeShopLib;
using ForgeShopDB.Entities;


namespace ForgeShopUI
{
    public class MainMenu : IMenu
    {
        private string userChoice;
        private Customer newCustomer;
        private NewCustomerMenu NewMenu;
        private ExistingCustomerMenu ExistingCustomer;
        private ManagerMenu Managers;
        
        private int TemporaryCustomer = 1;

        public MainMenu(DBContext context, IMapper mapper)
        {
            this.NewMenu = new NewCustomerMenu(new DBRepo(context,mapper));
        }

               public void start()
        {
            do{
                Console.WriteLine("Welcome to Zar's Forge Shop\nSelect an Option\n [0] New Customer\n [1] Existing Customer\n [2] Store Manager\n [3] Exit");
                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "0":
                        //call the newCustomer menu;
                        NewMenu.start();
                        break;
                    case "1":
                        //call the Existing Customer menu;
                        ExistingCustomer.start(TemporaryCustomer);
                        break;
                    case "2":
                        //Call the Manager Menu
                        Managers.start();
                        break;
                    case "3":
                        Console.WriteLine("Forge On!");
                        break;
                    default:
                        Console.WriteLine("Invalid Entry - Try again");
                    break;
                }

            }while(!(userChoice.Equals("3")));
        }
    }
}