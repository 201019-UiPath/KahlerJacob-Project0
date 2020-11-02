using System;
using System.Collections.Generic;

namespace ForgeShopDB.Entities
{
    public partial class Customer
    {
        public Customer()
        {
                    Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
