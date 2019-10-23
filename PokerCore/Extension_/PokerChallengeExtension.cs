using System;
using System.Collections.Generic;
using System.Linq;

namespace PokerCore
{
    static class PokerChallengeExtension
    {
        public static List<int> ToOrderByDescendingList(this Dictionary<int,int> dictionary)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
            var list = new List<int>();
            foreach(var item in dictionary)
            {
                for(var i = 0; i < item.Value; i++)
                {
                    list.Add(item.Key);
                }
            }
            list = list.OrderByDescending(x => x).ToList();
            return list;
        }

        public static int CompareTo(this List<int> list,List<int> other)
        {
            for(var i =0; i < list.Count; i++)
            {
                if (list[i] > other[i]) return 1;
                else if (list[i] < other[i]) return -1;
            }
            return 0;
        }
    }
}
