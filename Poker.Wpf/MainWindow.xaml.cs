using System;
using System.Collections.Generic;
using System.Windows;
using PokerCore;
using System.Linq;

namespace Poker.Wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var players = new List<PokerPlayer>();
            for(int i = 0; i < 4; i++)
            {
                var cards = new List<PokerCard>();
                for(int j = 0; j < 5; j++)
                {
                    cards.Add(GetRandomCard());
                }
                var player = new PokerPlayer { Name = Names[i], PokerCards = cards };
                players.Add(player);
            }
            UpdatePlayers(players);
            //get winners
            GetWinners(players);
        }

        private void GetWinners(List<PokerPlayer> players)
        {
            if (_pokerChallenge == null) _pokerChallenge = new PokerChallenge();
            var winners = _pokerChallenge.GetWinnersOfChallenge(players);

            var nameOfWinners = "";
            winners.ForEach(x => nameOfWinners += x + " ");

            WinnerText.Text = nameOfWinners;
        }

        private void UpdatePlayers(List<PokerPlayer> players)
        {
            var count = 0;
            foreach(var child in PlayersPanel.Children)
            {
                if(child is PlayerItem item)
                {
                    item.PlayerName = players[count].Name;
                    item.SetValuesByCards(players[count].PokerCards.ToList());
                    count++;
                }
            }
        }

        private PokerCard GetRandomCard()
        {
            if(_random==null) _random = new Random(DateTime.Now.Millisecond);
            var rank = _random.Next(2, 15);
            var suit = _random.Next(0, 4);
            return new PokerCard { Rank = rank, Suit = (PokerSuits)suit };
        }

        private Random _random;

        private string[] Names = new[] { "Joe", "Bob", "Jen", "Kai" };

        private IPokerChallenge _pokerChallenge;
    }
}
