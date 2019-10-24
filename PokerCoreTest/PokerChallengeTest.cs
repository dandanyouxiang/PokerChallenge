using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTest.Extensions.Contracts;
using PokerCore;
using System.Collections.Generic;

namespace PokerTest
{
    [TestClass]
    public class PokerChallengeTest
    {
        [ContractTestCase]
        public void PokerChallengeResultTest()
        {
            "Poker players challenge result test".Test(() =>
            {
                var result = GetChallengeResult(TestData.Data1);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Bob");
            });

            "Data string to players challenge result test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.DataString1);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Bob");
            });

            "DataString-2 to players challenge result test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.DataString2);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Bob");
            });

            "DataString-3 to players challenge result test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.DataString3);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Jen");
            });

            "DataString-4 to players challenge result test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.DataString4);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Jen");
            });
        }

        [ContractTestCase]
        public void SpecialDataTest()
        {
            "Flush Data Test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.FlushDataTest);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Joe");
            });

            "Three of a kind Data Test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.ThreeOfAKindTest);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Bob");
            });

            "One pair Data Test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.OnePairDataTest);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Bob");
            });

            "High card Data Test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.HighCarDataTest);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 1);
                Assert.IsTrue(result[0] == "Jen");
            });

            "Multiple winners Data Test".Test(() =>
            {
                var players = PokerConvertTest.ConvertToPlayer(TestData.MultiValueTest);
                var result = GetChallengeResult(players);
                Assert.IsTrue(result.Count == 2);
                Assert.IsTrue(result.Contains("Joe"));
                Assert.IsTrue(result.Contains("Bob"));
            });
        }

        private List<string> GetChallengeResult(List<PokerPlayer> players)
        {
            IPokerChallenge challenge = new PokerChallenge();
            var result = challenge.GetWinnersOfChallenge(players);
            return result;
        }
    }
}
