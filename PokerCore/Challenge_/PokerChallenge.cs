using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PokerCore
{
    public class PokerChallenge : IPokerChallenge
    {
        public List<string> GetWinnersOfChallenge(IEnumerable<PokerPlayer> players)
        {
            // value validate
            if (players == null) throw new ArgumentNullException(nameof(players));
            // create a detail generator
            var detailGenerator = new PokerDetailGenerator();
            // get the detail information about player
            var details = detailGenerator.GetDetail(players);
            // get the poker hand type
            details = GetPokerHandInformation(details);
            var pokerCompare = new PokerCompare();
            var winnerDetail = pokerCompare.GetWinners(details);
            return winnerDetail.Select(x => x.Name).ToList();
        }

        private IEnumerable<PokerDetailInformation> GetPokerHandInformation(IEnumerable<PokerDetailInformation> details)
        {
            IPokerHandGenerator pokerHandGenerator = new PokerHandGenerator();
            foreach (var detail in details)
            {
                detail.PokerHand = pokerHandGenerator.GetPokerHands(detail);
            }
            return details;
        }
    }
}
