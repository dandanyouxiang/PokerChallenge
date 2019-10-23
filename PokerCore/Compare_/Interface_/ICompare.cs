using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    interface ICompare
    {
        IEnumerable<PokerDetailInformation> GetWinners(PokerDetailInformation detail1, PokerDetailInformation detail2);
    }
}
