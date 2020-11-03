namespace ForgeShopDB
{
    public interface IInventoryMapper
    {
        Models.Inventory ParseInventory(Entities.Inventory inventory);

        Entities.Inventory ParseInventory(Models.Inventory inventory);
    }
}