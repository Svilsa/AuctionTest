using System.Collections.ObjectModel;
using Auction.Models;

namespace Auction
{
    public class Throttler : ThrottlerBase
    {
        public override void PutUpdates(string auctionName, Updates updates)
        {
            throw new System.NotImplementedException();
        }

        public override Collection<LotUpdate> PopUpdates(string auctionName)
        {
            throw new System.NotImplementedException();
        }
    }
}