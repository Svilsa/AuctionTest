namespace Auction;

public class Throttler : ThrottlerBase
{
    public override void PutUpdates(string auctionName, Updates updates)
    {
        throw new System.NotImplementedException();
    }

    public override Updates? PopUpdates(string auctionName)
    {
        throw new System.NotImplementedException();
    }
}