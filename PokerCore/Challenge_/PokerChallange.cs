using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class PokerChallange : IPokerChallange
    {
        public IEnumerable<PokerPlayer> GetWinnersOfChallange(IEnumerable<PokerPlayer> players)
        {
            var detailGenerator = new PokerDetailGenerator();
            var details = detailGenerator.GetDetail(players);
        }
    }
}
