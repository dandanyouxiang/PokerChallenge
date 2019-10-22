using System.Collections.Generic;

namespace PokerCore
{
    interface IDetailGenerator<T> where T: PokerDetail
    {
        /// <summary>
        /// Get poker details from poker players
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        IEnumerable<T> GetDetail(IEnumerable<PokerPlayer> players);
    }
}
