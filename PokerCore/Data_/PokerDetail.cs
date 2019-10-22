using System.Collections.Generic;

namespace PokerCore
{
    class PokerDetail
    {
        /// <summary>
        /// The poker hand of a group of poker cards
        /// </summary>
        public PokerHands PokerHand { get; set; }

        /// <summary>
        /// The number of each rank
        /// </summary>
        public Dictionary<int, int> CardDetail { get; set; }
    }
}
