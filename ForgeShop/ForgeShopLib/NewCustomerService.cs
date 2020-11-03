using ForgeShopDB.Models;
using ForgeShopDB;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using ForgeShopDB.Entities;

namespace ForgeShopLib
{
    public class NewCustomerService
    {
        private ICustomerRepo repo;

        public NewCustomerService(ICustomerRepo repo)
        {
            this.repo = repo;
        }
        
        public void AddCustomer(ForgeShopDB.Models.Customer newCust)
        {   /*
            //Making sure aliases are unique before adding
            Task<List<ForgeShopDB.Models.Customer>> getHerosTask = repo.GetAllCustomersAsync();
            foreach(var customer in getHerosTask.Result)
            {
                if(newCust.userName.Equals(ForgeShopDB.Entities.Customer.Username))
                {
                    throw new Exception("User Name should be unique. That user Name is taken");
                }
            }*/
            repo.AddCustomerAsync(newCust);
        }
    }
}