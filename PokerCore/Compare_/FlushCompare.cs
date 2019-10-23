using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PokerCore
{
    /// <summary>
    /// Two Flush compare and get the winner
    /// </summary>
    class FlushCompare : PokerHandCompare
    {
        public override List<PokerDetailInformation> GetWinner(PokerDetailInformation detail1, PokerDetailInformation detail2)
        {
            return base.GetWinner(detail1, detail2);
        }
    }
}
