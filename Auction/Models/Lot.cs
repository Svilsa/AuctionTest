namespace Auction.Models
{
    public class Lot
    {
        public uint Id;
        public double Price;
        public double Volume;

        public Lot(uint id, double price, double volume)
        {
            Id = id;
            Price = price;
            Volume = volume;
        }
    }
}