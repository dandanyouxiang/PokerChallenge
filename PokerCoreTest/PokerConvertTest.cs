using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using PokerCovert;
using PokerCore;
using MSTest.Extensions.Contracts;

namespace PokerTest
{
    [TestClass]
    public class PokerConvertTest
    {
        [ContractTestCase]
        public void StringConvertTest()
        {
            "Covert DataString1 in TestData".Test(() =>
            {
                var players = ConvertToPlayer(TestData.DataString1);
                Assert.IsTrue(players.Count == 3);
                players.ForEach(x => Assert.IsTrue(x.PokerCards.Count == 5));
            });

            "Convert DataString2 in TestData".Test(() =>
            {
                var players = ConvertToPlayer(TestData.DataString2);
                Assert.IsTrue(players.Count == 3);
                players.ForEach(x => Assert.IsTrue(x.PokerCards.Count == 5));
            });

            "Convert DataString3 in TestData".Test(() =>
            {
                var players = ConvertToPlayer(TestData.DataString3);
                Assert.IsTrue(players.Count == 3);
                players.ForEach(x => Assert.IsTrue(x.PokerCards.Count == 5));
            });

            "Convert DataString4 in TestData".Test(() =>
            {
                var players = ConvertToPlayer(TestData.DataString4);
                Assert.IsTrue(players.Count == 3);
                players.ForEach(x => Assert.IsTrue(x.PokerCards.Count == 5));
            });
        }

        public static List<PokerPlayer> ConvertToPlayer(string[] dataString)
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
