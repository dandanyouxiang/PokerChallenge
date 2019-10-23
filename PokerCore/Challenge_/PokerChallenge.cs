using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class PokerChallenge : IPokerChallenge
    {
        public IEnumerable<PokerPlayer> GetWinnersOfChallenge(IEnumerable<PokerPlayer> players)
        {
            // value validate
            if (players == null) throw new ArgumentNullException(nameof(players));
            // create a detail generator
            var detailGenerator = new PokerDetailGenerator();
            // get the detail information about player
            var details = detailGenerator.GetDetail(players);
            // get the poker hand type
            details = GetPokerHandInformation(details);
        }

        private IEnumerable<PokerDetailInformation> GetPokerHandInformation(IEnumerable<PokerDetailInformation> details)
        {
            var pokerHandGenerator = new PokerHandGenerator();
            foreach (var detail in details)
            {
                detail.PokerHand = pokerHandGenerator.GetPokerHands(detail);
            }
            return details;
        }
    }
}
