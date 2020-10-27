using System;
namespace ProjectZeroUI
{
    public class MainMenu : IMenu
    {
        private string userChoice;
        public void start()
        {
            do{
                    int userChoice = new int();
                    Console.WriteLine("Welcome to Zar's Forge Online Portal!");
                    Console.WriteLine("Please select from the following menu\n [0] - Customer Sign In\n [1] - Manager Sign In\n [2] - Exit Portal");
                    Console.ReadLine(userChoice);

                    switch(userChoice)
                    {
                        case "0":
                            //Call the CustomerLogin
                            
                            CustLogin.start();
                            break;
                        case "1":
                            
                            //Call managerLogin
                            ManagerLogin.start();
                            break;
                        case "2":
                            Console.WriteLine("Thank you for visiting!");
                            Console.ReadLine();
                        default:
                        //
                        Console.WriteLine("Invalid Menu Item.  Please Try Again");
                    }
                }while(!userChoice.Equals("2"));

            
        }

      

    }
}