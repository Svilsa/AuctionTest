global using Updates = System.Collections.Generic.List<Auction.Models.LotUpdate>;

namespace Auction.Models;

public enum Action
{
    Add,
    Change,
    Del
}

public struct LotUpdate
{
    public readonly Action Action;
    public Lot Lot;

    public LotUpdate(Action action, Lot lot)
    {
        Action = action;
        Lot = lot;
    }
}