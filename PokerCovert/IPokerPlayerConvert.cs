using System;
using System.Collections.Generic;
using System.Text;
using PokerCore;

namespace PokerCovert
{
    public interface IPokerPlayerConvert<T>
    {
        PokerPlayer Convert(T value);
    }
}
