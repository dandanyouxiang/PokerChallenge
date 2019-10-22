using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class PokerDetailInformation : PokerDetail
    {
        /// <summary>
        /// The poker hand of a group of poker cards
        /// </summary>
        public PokerHands PokerHand { get; set; }

        /// <summary>
        /// Name of player
        /// </summary>
        public string Name { get; set; }
    }
}
