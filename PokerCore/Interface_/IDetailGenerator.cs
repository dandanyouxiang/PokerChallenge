using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    interface IDetailGenerator
    {
        /// <summary>
        /// Get poker details from poker players
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        IEnumerable<PokerDetail> GetDetail(IEnumerable<PokerPlayer> players);
    }
}
