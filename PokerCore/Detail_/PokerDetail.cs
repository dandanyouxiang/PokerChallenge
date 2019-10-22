using System.Collections.Generic;

namespace PokerCore
{
    /// <summary>
    /// Poker Detail Information, Not just for Poker hand, it can be used in another poker game 
    /// </summary>
    class PokerDetail
    {
        /// <summary>
        /// The value of suit
        /// </summary>
        public int SuitNumber { get; set; }
        /// <summary>
        /// The number of each rank
        /// </summary>
        public Dictionary<int, int> CardDetail { get; set; }
    }
}
