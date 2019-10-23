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
            PrintHelpInformation();

            var valueInput = Console.ReadLine().Replace(" ", "");
            var challenge = new PokerCore.PokerChallenge();
            var inputs = new List<string>();
            while (true)
            {
                if (valueInput == string.Empty)
                {
                    try
                    {
                        var players = ConvertToPlayer(inputs);
                        if (players.Count > 0)
                        {
                            var winners = challenge.GetWinnersOfChallenge(players);
                            players.Clear();
                            var name = "";
                            winners.ForEach(x => name += x + " ");
                            Console.WriteLine(name + "wins");
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine($"Error Message: {e.Message}");
                        Console.WriteLine("Invalid data, Input correct data like 8S,8D,AD,QD,JH");
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine($"Error Message: {e.Message}");
                        Console.WriteLine("Invalid data, Input correct data like 8S,8D,AD,QD,JH");
                    }
                    finally
                    {
                        inputs.Clear();
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Enter data:");
                }
                else inputs.Add(valueInput);
                valueInput = Console.ReadLine().Replace(" ", "");
            }
        }

        private static void PrintHelpInformation()
        {
            Console.WriteLine("Poker Hand Challange Games. Double enter to get winner");
            Console.WriteLine("Input Name and Card Value like this");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Joe");
            Console.WriteLine("8S,8D,AD,QD,JH");
            Console.WriteLine("Bob");
            Console.WriteLine("8A,8D,KD,QD,JH");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Enter data:");
        }

        private static List<PokerPlayer> ConvertToPlayer(List<string> dataString)
        {
            var players = new List<PokerPlayer>();
            var converter = new StringToPokerPlayerConverter();
            for (var i = 0; i < dataString.Count; i += 2)
            {
                var thePlayer = converter.Convert((dataString[i], dataString[i + 1]));
                if (thePlayer.PokerCards.Count != 5)
                {
                    Console.WriteLine("Must Input 5 Cards and split with ,  like this 8A,8D,KD,QD,JH");
                    return new List<PokerPlayer>();
                }
                players.Add(thePlayer);
            }
            return players;
        }
    }
}
