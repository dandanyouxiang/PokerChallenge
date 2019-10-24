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

        /// <summary>
        /// winner is Joe
        /// </summary>
        public static string[] FlushDataTest = new[]
        {
            "Joe",
            "as,ks,qs,js,10s",
            "Bob",
            "2s,3s,4s,5s,6s",
            "Jen",
            "4h,4c,4s,3d,2d",
            "Sally",
            "5c,6c,7c,8c,9c"
        };

        /// <summary>
        /// winner is Bob
        /// </summary>
        public static string[] ThreeOfAKindTest = new[]
        {
            "Joe",
            "4s,5s,6s,4c,4d",
            "Bob",
            "4s,4c,4d,js,qs",
            "Jen",
            "3s,3c,2d,3d,js"
        };

        /// <summary>
        /// winner is Bob
        /// </summary>
        public static string[] OnePairDataTest = new[]
        {
            "Joe",
            "2S,2D,3s,4s,5s",
            "Bob",
            "2c,2h,6s,7s,8s",
            "Jen",
            "as,qs,3d,ks,js"
        };

        /// <summary>
        /// winner is Jen 
        /// </summary>
        public static string[] HighCarDataTest = new[]
        {
            "Joe",
            "AS,KD,3s,4s,5s",
            "Bob",
            "Ac,Kh,3s,4s,6s",
            "Jen",
            "Ac,kh,3s,4s,7s"
        };

        /// <summary>
        /// winner is Joe and Bob
        /// </summary>
        public static string[] MultiValueTest = new[]
        {
            "Joe",
            "2S,2D,3s,4s,5s",
            "Bob",
            "2S,2D,3s,4s,5s",
            "Jen",
            "as,qs,3d,ks,js"
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
