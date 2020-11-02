namespace ForgeShopDB.Models
{
    public class Order
    {
        
        
        public int id { get; set; }
        public int storeId { get; set; }
        public int custId { get; set; }
        public int price { get; set; }
        public int ball { get; set; }
        public int cross { get; set; }
        public int flat { get; set; }
        public int aviltwenty { get; set; }
        public int anvilforty { get; set; }
        public int anvilhundred { get; set; }
        public int apronblack { get; set; }
        public int apronbrown { get; set; }
        public System.DateTime date { get; set; }

    }
}