namespace PokerCore
{
    /// <summary>
    /// An interface for check PokerHands
    /// </summary>
    interface IPokerHandRule
    {
        bool IsMatched(PokerDetail detail);

        PokerHands CurrentPokerHand { get; set; }
    }
}
