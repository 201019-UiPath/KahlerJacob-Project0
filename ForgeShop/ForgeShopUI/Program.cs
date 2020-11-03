using System;
using ForgeShopLib;
using ForgeShopDB.Entities;
using ForgeShopDB;

namespace ForgeShopUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu main = new MainMenu(new DBContext(), new DBMapper());
            main.start();

        }
    }
}
