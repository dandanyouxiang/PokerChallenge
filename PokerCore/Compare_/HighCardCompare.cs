using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class HighCardCompare : PokerHandCompare
    {
        public override List<PokerDetailInformation> GetWinner(PokerDetailInformation detail1, PokerDetailInformation detail2)
        {
            return base.GetWinner(detail1, detail2);
        }
    }
}
