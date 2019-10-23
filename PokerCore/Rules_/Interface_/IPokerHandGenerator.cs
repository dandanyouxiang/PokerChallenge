using System;
using System.Collections.Generic;

namespace PokerCore
{
    interface IPokerHandGenerator
    {
        PokerHands GetPokerHands(PokerDetail detail);
    }
}
