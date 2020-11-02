using System;
using System.Collections.Generic;

namespace ForgeShopDB.Entities
{
    public partial class Location
    {
        public Location()
        {
            Inventory = new HashSet<Inventory>();
            Manager = new HashSet<Manager>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual ICollection<Manager> Manager { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
