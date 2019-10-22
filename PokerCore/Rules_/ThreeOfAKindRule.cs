using System.Linq;

namespace PokerCore
{
    class ThreeOfAKindRule : IPokerHandRule
    {
        public PokerHands CurrentPokerHand { get; set; } = PokerHands.ThreeOfAKind;

        public bool IsMatched(PokerDetail detail)
        {
            if (detail == null) throw new System.ArgumentNullException(nameof(detail));

            return detail.CardDetail.Any(x => x.Value >= 3);
        }
    }
}
