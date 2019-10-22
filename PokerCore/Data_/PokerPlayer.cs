using System.Collections.Generic;

namespace PokerCore
{
    class PokerPlayer
    {
        /// <summary>
        /// The name of this play
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The cards of the play, you can change the card number for defferent game rule
        /// </summary>
        public IList<PokerCard> PokerCards { get; set; }
    }
}
