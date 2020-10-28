namespace ProjectZeroUI
{
    public class ManagerLogin : ILogIn
    {       
        string userName;
        string userPin;

        public string GetUserName(){
            System.Console.WriteLine("Enter your Manager User Name");
            userName = System.Console.ReadLine();

            return userName;
            

        }

        public string GetUserPin(){
            System.Console.WriteLine("Enter your Pin");
            userPin = System.Console.ReadLine();
            return userPin;


        }

        public int CheckLogin(string name, string pin){
            int id = 0;
            string IncName = name;
            string IncPin = pin;
            //open file for login
            //check table for user
            //check that user.pin is same
            //return the user.id
            //if not found return 0
            return id;
        }
    }
}