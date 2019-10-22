namespace PokerCore
{
    /// <summary>
    /// poker hands
    /// </summary>
    enum PokerHands
    {
        /// <summary>
        /// Same suit
        /// </summary>
        Flush,

        /// <summary>
        /// Have three cards with the same value，like (8S,8H,8D,3S,4S)
        /// </summary>
        ThreeOfAKind,

        /// <summary>
        /// Have one pair,like (1S,2S,3S,4S,4H)
        /// </summary>
        OnePair,

        /// <summary>
        /// without any pair , and the suits are defferent,like(1S,2H,3H,4H,5H)
        /// </summary>
        HighCard
    }
}
