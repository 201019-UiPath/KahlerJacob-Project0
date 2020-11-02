using System;
using System.Collections.Generic;

namespace ForgeShopDB.Entities
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int Storeid { get; set; }
        public int Custid { get; set; }
        public int Price { get; set; }
        public int Ballhammer { get; set; }
        public int Crosshammer { get; set; }
        public int Flathammer { get; set; }
        public int Aviltwenty { get; set; }
        public int Anvilforty { get; set; }
        public int Anvilhundred { get; set; }
        public int Apronblack { get; set; }
        public int Apronbrown { get; set; }
        public DateTime Date { get; set; }

        public virtual Customer Cust { get; set; }
        public virtual Location Store { get; set; }
    }
}
