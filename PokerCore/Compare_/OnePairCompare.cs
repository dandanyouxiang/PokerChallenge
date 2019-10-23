using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class OnePairCompare : PokerHandCompare
    {
        public override List<PokerDetailInformation> GetWinner(PokerDetailInformation detail1, PokerDetailInformation detail2)
        {
            var value1 = GetValueOfPair(detail1);
            var value2 = GetValueOfPair(detail2);
            if (value1 == value2)
            {
                return base.GetWinner(detail1, detail2);
            }
            if (value1 > value2) return new List<PokerDetailInformation> { detail1 };
            else return new List<PokerDetailInformation> { detail2 };
        }

        private int GetValueOfPair(PokerDetailInformation detail)
        {
            var currentValue = -1;
            foreach(var item in detail.CardDetail)
            {
                // find the biggest value of pair, because it maybe exist two pairs
                if (item.Value == 2 && item.Key > currentValue) currentValue = item.Key;
            }
            if (currentValue < 0) throw new InvalidOperationException("Does not exist one pair, check the rule first");

            return currentValue;
        }
    }
}
