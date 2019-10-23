using System;
using PokerCore;
using PokerTest;
using PokerCovert;
using System.Linq;
using System.Collections.Generic;

namespace PokerChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var challenge = new PokerCore.PokerChallenge();
            var players = ConvertToPlayer(TestData.DataString3);
            var winners = challenge.GetWinnersOfChallenge(players);
            var name = "";
            winners.ForEach(x => name += x + " ");
            Console.WriteLine(name + "wins");
            Console.ReadLine();
        }

        private static List<PokerPlayer> ConvertToPlayer(string[] dataString)
        {
            var players = new List<PokerPlayer>();
            var converter = new StringToPokerPlayerConverter();
            for (var i = 0; i < dataString.Length; i += 2)
            {
                var thePlayer = converter.Convert((dataString[i], dataString[i + 1]));
                players.Add(thePlayer);
            }
            return players;
        }
    }
}
