using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class PokerChallenge : IPokerChallenge
    {
        public IEnumerable<PokerPlayer> GetWinnersOfChallenge(IEnumerable<PokerPlayer> players)
        {
            var detailGenerator = new PokerDetailGenerator();
            var details = detailGenerator.GetDetail(players);

        }
    }
}
