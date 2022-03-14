namespace Auction.Models
{
    public struct Lot
    {
        public readonly uint Id;
        public readonly double Price;
        public readonly double Volume;

        public Lot(uint id, double price, double volume)
        {
            this.Id = id;
            this.Price = price;
            this.Volume = volume;
        }
    }
}