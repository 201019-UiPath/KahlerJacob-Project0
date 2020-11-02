using System;
using System.Collections.Generic;

namespace ForgeShopDB.Entities
{
    public partial class Manager
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Pin { get; set; }
        public int Storeid { get; set; }

        public virtual Location Store { get; set; }
    }
}
