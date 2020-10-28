namespace ProjectZeroUI
{
    public interface ILogIn
    {
       
         string GetUserName();
         string GetUserPin();
         int CheckLogin(string name,string pin);
    }
}