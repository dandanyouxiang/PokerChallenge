using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    interface IPokerCompare
    {
        List<PokerDetailInformation> GetWinners(IEnumerable<PokerDetailInformation> details);
    }
}
