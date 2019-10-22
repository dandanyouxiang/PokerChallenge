﻿using System.Collections.Generic;

namespace PokerCore
{
    interface IPokerChallange
    {
        /// <summary>
        /// Get the correct winner list of the challange
        /// </summary>
        /// <param name="players">The players' information</param>
        /// <returns> The winners </returns>
        IEnumerable<PokerPlayer> GetWinnersOfChallange(IEnumerable<PokerPlayer> players);
    }
}