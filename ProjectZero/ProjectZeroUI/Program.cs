using System;

namespace ProjectZeroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu main = new MainMenu();
            main.start();
            string userInput;
            Console.Readline(userInput);

        }

    }
}
