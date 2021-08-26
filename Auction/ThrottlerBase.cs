using System.Collections.Generic;
using System.Collections.ObjectModel;
using Auction.Models;

namespace Auction
{
    public abstract class ThrottlerBase
    {
        public abstract void PutUpdates(string auctionName, Updates updates);
        public abstract Collection<LotUpdate> PopUpdates(string auctionName);
    }
}