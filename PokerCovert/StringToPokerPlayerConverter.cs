using System;
using System.Collections.Generic;
using System.Text;
using PokerCore;
using System.Linq;

namespace PokerCovert
{
    public class StringToPokerPlayerConverter : IPokerPlayerConvert<(string name, string value)>
    {
        public PokerPlayer Convert((string name, string value) info)
        {
            return new PokerPlayer
            {
                Name = info.name,
                PokerCards = ConvertValueToCards(info.value)
            };
        }

        private List<PokerCard> ConvertValueToCards(string value)
        {
            value = value.ToUpper();
            // remove all blank chart
            value = value.Replace(" ", "");
            var cardValues = value.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            return cardValues.Select(x => ConvertToCard(x)).ToList();
        }

        private PokerCard ConvertToCard(string value)
        {
            if (value.Length < 2 || value.Length > 3) throw new ArgumentException($"{value} is wrong data");
            var rank = value.Substring(0, value.Length - 1);
            var suit = value.Substring(value.Length - 1);
            return new PokerCard { Rank = GetRank(rank), Suit = GetPokerSuit(suit) };
        }

        private int GetRank(string rank)
        {
            if (rank == "J") return 11;
            if (rank == "Q") return 12;
            if (rank == "K") return 13;
            if (rank == "A") return 14;
            var result = int.TryParse(rank, out var theRank);
            if (!result) throw new ArgumentException($"{rank} is an error data");
            return theRank;
        }

        private PokerSuits GetPokerSuit(string suit)
        {
            if (suit == "S") return PokerSuits.Spade;
            if (suit == "H") return PokerSuits.Heart;
            if (suit == "D") return PokerSuits.Diamond;
            return PokerSuits.Club;
        }
    }
}
