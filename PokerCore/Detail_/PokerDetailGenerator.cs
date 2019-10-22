using System;
using System.Collections.Generic;
using System.Text;

namespace PokerCore
{
    class PokerDetailGenerator : IDetailGenerator<PokerDetailInformation>
    {
        public IEnumerable<PokerDetailInformation> GetDetail(IEnumerable<PokerPlayer> players)
        {
            if (players == null) throw new ArgumentNullException(nameof(players), "players can not be null");

            var pokerDetails = new List<PokerDetailInformation>();
            foreach (var player in players)
            {
                var detail = GetCardDetail(player);
                pokerDetails.Add(detail);
            }
            return pokerDetails;
        }

        private PokerDetailInformation GetCardDetail(PokerPlayer player)
        {
            var details = new Dictionary<int, int>();
            var suitCount = 0;
            var suitTypes = new List<PokerSuits>();
            foreach (var card in player.PokerCards)
            {
                if (details.ContainsKey(card.Rank)) details[card.Rank] += 1;
                else details[card.Rank] = 1;

                if (!suitTypes.Contains(card.Suit))
                {
                    suitTypes.Add(card.Suit);
                    suitCount += 1;
                }
            }
            return new PokerDetailInformation
            {
                SuitNumber = suitCount,
                CardDetail = details,
                Name = player.Name
            };
        }
    }
}
