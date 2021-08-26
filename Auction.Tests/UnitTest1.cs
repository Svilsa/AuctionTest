using Auction.Models;
using Xunit;
using Action = Auction.Models.Action;

namespace Auction.Tests
{
    public class UnitTest1
    {
        private const string AuctionName = "au1";
        
        [Fact]
        public void SimpleTest()
        {
            var tr = new Throttler();
            
            
            var firstUpdates = new Updates
            {
                new (Action.Add, new Lot(1, 65, 1000)),
                new (Action.Add, new Lot(2, 66, 1000)),
                new (Action.Add, new Lot(3, 67, 1000)),
            };
            
            tr.PutUpdates(AuctionName, firstUpdates);

            var secondUpdates = new Updates
            {
                new (Action.Add, new Lot(1, 65, 1000)),
                new (Action.Add, new Lot(2, 66, 1000)),
                new (Action.Add, new Lot(3, 67, 1000)),
            };

            tr.PutUpdates(AuctionName, secondUpdates);
            
        }
    }
}