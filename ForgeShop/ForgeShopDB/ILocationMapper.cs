namespace ForgeShopDB
{
    public interface ILocationMapper
    {
        Models.Location ParseLocation(Entities.Location location);

        Entities.Location ParseLocation(Models.Location location);
         
    }
}