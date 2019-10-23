using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class ThreeOfAKindCompare : PokerHandCompare
    {
        public override List<PokerDetailInformation> GetWinner(PokerDetailInformation detail1, PokerDetailInformation detail2)
        {
            var value1 = GetTheValueOfThreeKind(detail1);
            var value2 = GetTheValueOfThreeKind(detail2);
            if (value1 == value2)
            {
                return base.GetWinner(detail1, detail2);
            }
            else if (value1 > value2) return new List<PokerDetailInformation> { detail1 };
            else return new List<PokerDetailInformation> { detail2 };
        }

        private int GetTheValueOfThreeKind(PokerDetailInformation detail)
        {
            foreach(var info in detail.CardDetail)
            {
                if (info.Value == 3) return info.Key;
            }
            throw new InvalidOperationException("Does not exist three a kind, check the rule first");
        }
    }
}
