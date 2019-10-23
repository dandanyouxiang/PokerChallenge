using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerCore
{
    class PokerCompare : IPokerCompare
    {
        public List<PokerDetailInformation> GetWinners(IEnumerable<PokerDetailInformation> details)
        {
            var sortedDetails = SortTheDetails(details);
            return GetWinnerBySortedDetails(sortedDetails);
        }

        private Dictionary<PokerHands, List<PokerDetailInformation>> SortTheDetails(
            IEnumerable<PokerDetailInformation> details)
        {
            var dictionary = new Dictionary<PokerHands, List<PokerDetailInformation>>();
            foreach (var detail in details)
            {
                if (dictionary.ContainsKey(detail.PokerHand)) dictionary[detail.PokerHand].Add(detail);
                else dictionary[detail.PokerHand] = new List<PokerDetailInformation> { detail };
            }
            return dictionary;
        }

        private List<PokerDetailInformation> GetWinnerBySortedDetails(
            Dictionary<PokerHands, List<PokerDetailInformation>> sortedDetails)
        {
            var pokerHand = sortedDetails.Keys.OrderBy(x => x).FirstOrDefault();
            return GetWinnerCore(sortedDetails[pokerHand], _compareDictionary[pokerHand]);
        }

        private List<PokerDetailInformation> GetWinnerCore(List<PokerDetailInformation> details, ICompare compare)
        {
            if (details == null || details.Count < 1) throw new InvalidOperationException("Wrong data");
            if (details.Count == 1) return details;
            var currentWinners = new List<PokerDetailInformation>() { details[0] };
            for (var i = 1; i < details.Count; i++)
            {
                var compareResult = compare.GetWinner(currentWinners.First(), details[i]);
                if (compareResult.Count > 1) currentWinners.Add(details[i]);
                else currentWinners = compareResult;
            }
            return currentWinners;
        }

        private Dictionary<PokerHands, ICompare> _compareDictionary = new Dictionary<PokerHands, ICompare>
        {
            { PokerHands.Flush,new FlushCompare() },
            { PokerHands.ThreeOfAKind,new ThreeOfAKindCompare() },
            { PokerHands.OnePair,new OnePairCompare() },
            { PokerHands.HighCard,new HighCardCompare() }
        };
    }
}
