using System;
using System.Collections.Generic;

namespace PokerCore
{
    class PokerHandGenerator : IPokerHandGenerator
    {
        private readonly List<IPokerHandRule> _rules = new List<IPokerHandRule>
        {
            new FlushRule(),
            new ThreeOfAKindRule(),
            new OnePairRule(),
            new HighCardRule()
        };

        public PokerHands GetPokerHands(PokerDetail detail)
        {
            foreach (var rule in _rules)
            {
                if (rule.IsMatched(detail)) return rule.CurrentPokerHand;
            }
            // throw an error if there is no rule can match the detail
            throw new InvalidOperationException("Rules Missing, Check your rules first.");
        }
    }
}
