namespace ProjectZeroUI
{
    public class CustLogin : ILogIn
    {
        string userName;
        string userPin;

        public void GetUserName(){
            Console.WriteLine("Enter your Customer User Name");
            Console.ReadLine(userName);
            

        }

        public void GetUserPin(){
            Console.WriteLine("Enter your Pin");
            Console.ReadLine(userPin);


        }

        public int CheckLogin(string user, string pin){

            //open file for login
            //check table for user
            //check that user.pin is same
            //return the user.id
            //if not found return 0
        }


        
    }
}