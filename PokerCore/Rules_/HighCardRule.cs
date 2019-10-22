using System.Linq;

namespace PokerCore
{
    class HighCardRule : IPokerHandRule
    {
        public PokerHands CurrentPokerHand { get; set; } = PokerHands.HighCard;
        public bool IsMatched(PokerDetail detail)
        {
            if (detail == null) throw new System.ArgumentNullException(nameof(detail));

            return detail.CardDetail.All(x => x.Value == 1);
        }
    }
}
