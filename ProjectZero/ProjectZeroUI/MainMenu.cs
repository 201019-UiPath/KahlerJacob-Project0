using System;
namespace ProjectZeroUI
{
    public class MainMenu : IMenu
    {
        private string userChoice;
        public void start()
        {
           
                   
                Console.WriteLine("Welcome to Zar's Forge Online Portal!");
                Console.WriteLine("Please select from the following menu\n [0] - New Customer\n [1] - Customer Sign In\n [2] - Manager Sign In\n [3] - Exit Portal");
                string userChoice = Console.ReadLine();
                string name;
                string pin;

                switch(userChoice)
                {
                    case "0":

                    break;
                    case "1":
                        //Call the CustomerLogin
                        ILogIn customer = new CustLogin();
                        name = customer.GetUserName();
                        pin = customer.GetUserPin();
                        int custId = customer.CheckLogin(name,pin);
                        while (custId == 0)
                        {
                            Console.WriteLine("Login Error!  User and Pin did not match!\n [0] - Try Again\n[1] - Go Back");
                            string userInput;
                            userInput = Console.ReadLine();

                            switch(userInput)
                            {
                                case "0":
                                    name = customer.GetUserName();
                                    pin = customer.GetUserPin();
                                    custId = customer.CheckLogin(name, pin);
                                    break;

                                case "1":
                                    break;

                                default:
                                break;
                            }
                        }
                        break;
                    case "2":
                            
                        //Call managerLogin
                            
                        ILogIn manager = new ManagerLogin();
                        name = manager.GetUserName();
                        pin = manager.GetUserPin();
                        int managerId = manager.CheckLogin(manager.GetUserName(), manager.GetUserPin());
                        while (managerId == 0)
                            {
                                Console.WriteLine("Login Error!  User and Pin did not match!\n [0] - Try Again\n[1] - Go Back");
                                string userInput;
                                userInput = Console.ReadLine();

                                switch(userInput)
                                {
                                    case "0":
                                        name = manager.GetUserName();
                                        pin = manager.GetUserPin();
                                        managerId = manager.CheckLogin(name, pin);
                                        break;

                                    case "1":
                                        break;

                                    default:
                                    break;
                                }
                                    

                        
                            }
                           
                        break;
                        case "3":
                            Console.WriteLine("Thank you for visiting!");
                            break;

                    default:
                    //
                    Console.WriteLine("Invalid Menu Item.  Please Try Again");
                    break;
                }
             
                   
                    


           

            
        }

      

    }
}