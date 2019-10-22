using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerCore
{
    class OnePairRule : IPokerHandRule
    {
        public PokerHands CurrentPokerHand { get; set; } = PokerHands.OnePair;
        public bool IsMatched(PokerDetail detail)
        {
            if (detail == null) throw new System.ArgumentNullException(nameof(detail));

            return detail.CardDetail.Any(x => x.Value == 2);
        }
    }
}
