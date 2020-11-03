using System;
using System.Collections.Generic;

namespace ForgeShopDB.Entities
{
    public partial class Inventory
    {
        public int Id { get; set; }
        public int Storeid { get; set; }
        public int Ballhammer { get; set; }
        public int Flathammer { get; set; }
        public int Crosshammer { get; set; }
        public int Apronbrown { get; set; }
        public int Apronblack { get; set; }
        public int Anvilsmall { get; set; }
        public int Anvilmed { get; set; }
        public int Anvillarge { get; set; }

        public virtual Location Store { get; set; }
    }
}
