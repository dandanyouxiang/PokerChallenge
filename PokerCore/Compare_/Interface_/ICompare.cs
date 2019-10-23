using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    interface ICompare
    {
        List<PokerDetailInformation> GetWinner(PokerDetailInformation detail1, PokerDetailInformation detail2);
    }

    abstract class PokerHandCompare : ICompare
    {
        public virtual List<PokerDetailInformation> GetWinner(PokerDetailInformation detail1, PokerDetailInformation detail2)
        {
            var list1 = detail1.CardDetail.ToOrderByDescendingList();
            var list2 = detail2.CardDetail.ToOrderByDescendingList();
            var compareResult = list1.CompareTo(list2);
            if (compareResult > 0) return new List<PokerDetailInformation> { detail1 };
            else if (compareResult < 0) return new List<PokerDetailInformation> { detail2 };
            else return new List<PokerDetailInformation> { detail1, detail2 };
        }
    }
}
