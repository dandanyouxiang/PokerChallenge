namespace PokerCore
{
    class FlushRule : IPokerHandRule
    {
        public PokerHands CurrentPokerHand { get; set; } = PokerHands.Flush;

        public bool IsMatched(PokerDetail detail)
        {
            if (detail == null) throw new System.ArgumentNullException(nameof(detail));
            
            return detail.SuitNumber == 1;
        }
    }
}
