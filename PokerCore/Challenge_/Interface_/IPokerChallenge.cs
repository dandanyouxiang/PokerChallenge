using System.Collections.Generic;

namespace PokerCore
{
    public interface IPokerChallenge
    {
        /// <summary>
        /// Get the correct winner list of the challange
        /// </summary>
        /// <param name="players">The players' information</param>
        /// <returns> The winners </returns>
        List<string> GetWinnersOfChallenge(IEnumerable<PokerPlayer> players);
    }
}
