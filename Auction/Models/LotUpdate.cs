namespace Auction.Models
{
    public enum Action
    {
        Add,
        Change,
        Del
    }

    public class LotUpdate
    {
        public Action Action;
        public Lot Lot;

        public LotUpdate(Action action, Lot lot)
        {
            Action = action;
            Lot = lot;
        }
    }
}