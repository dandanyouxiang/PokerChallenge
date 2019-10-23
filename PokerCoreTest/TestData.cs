using PokerCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerTest
{
    public class TestData
    {
        public static string[] DataString1 = new[]
        {
            "Joe",
            "8S,8D,AD,QD,JH",
            "Bob",
            "as,qs,8s,6s,4s",
            "Sally",
            "4s,4H,3H,QC,8C"
        };

        public static string[] DataString2 = new[]
        {
            "Joe",
            "Q D,8D, KD,7D,3D",
            "Bob",
            "as,qs,8 s,6s,4s",
            "Sally",
            "4s,4H,3H,QC,8C"
        };

        public static string[] DataString3 = new[]
        {
            "Joe",
            "3H,5D,9c,9D,    QH",
            "Jen",
            "5C,7D,9H,9S,QS",
            "Bob",
            "2H,2c,5s,10c,ah"
        };

        public static string[] DataString4 = new[]
        {
            "Joe",
            "2H,3D,4c,5D,10  H",
            "Jen",
            "5C,7D,8H,9S,QD",
            "Bob",
            "2C,4 D,5s,10c,jh"
        };

        public static List<PokerPlayer> Data1 = new List<PokerPlayer>()
        {
            new PokerPlayer
            {
                Name ="Joe",
                PokerCards =new List<PokerCard>
                {
                    new PokerCard{Suit=PokerSuits.Spade,Rank=8},
                    new PokerCard{Suit=PokerSuits.Diamond,Rank=8},
                    new PokerCard{Suit=PokerSuits.Diamond,Rank=14},
                    new PokerCard{Suit=PokerSuits.Diamond,Rank=12},
                    new PokerCard{Suit=PokerSuits.Heart,Rank=10}
                }
            },
            new PokerPlayer
            {
                Name ="Bob",
                PokerCards =new List<PokerCard>
                {
                    new PokerCard{Suit=PokerSuits.Spade,Rank=14},
                    new PokerCard{Suit=PokerSuits.Spade,Rank=12},
                    new PokerCard{Suit=PokerSuits.Spade,Rank=8},
                    new PokerCard{Suit=PokerSuits.Spade,Rank=6},
                    new PokerCard{Suit=PokerSuits.Spade,Rank=4}
                }
            },
             new PokerPlayer
            {
                Name ="Sally",
                PokerCards =new List<PokerCard>
                {
                    new PokerCard{Suit=PokerSuits.Spade,Rank=4},
                    new PokerCard{Suit=PokerSuits.Heart,Rank=4},
                    new PokerCard{Suit=PokerSuits.Heart,Rank=3},
                    new PokerCard{Suit=PokerSuits.Club,Rank=12},
                    new PokerCard{Suit=PokerSuits.Club,Rank=8}
                }
            }
        };
    }
}
