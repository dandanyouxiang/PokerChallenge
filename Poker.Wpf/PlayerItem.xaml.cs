using PokerCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Poker.Wpf
{
    /// <summary>
    /// PlayerItem.xaml 的交互逻辑
    /// </summary>
    public partial class PlayerItem : UserControl, INotifyPropertyChanged
    {
        public PlayerItem()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string PlayerName
        {
            get => _playerName;
            set
            {
                _playerName = value;
                OnPropertyChanged(nameof(PlayerName));
            }
        }
        private string _playerName = "Joe";

        public List<PlayerItemModel> Values
        {
            get => _values;
            set
            {
                _values = value;
                OnPropertyChanged(nameof(Values));
            }
        }

        private List<PlayerItemModel> _values = new List<PlayerItemModel>
        {
            new PlayerItemModel{Rank="2",Image="./Resource/spade.png"},
            new PlayerItemModel{Rank="A",Image="./Resource/spade.png"},
            new PlayerItemModel{Rank="K",Image="./Resource/spade.png"},
            new PlayerItemModel{Rank="4",Image="./Resource/spade.png"},
            new PlayerItemModel{Rank="5",Image="./Resource/spade.png"},
        };

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetValuesByCards(List<PokerCard> cards)
        {
            var values = new List<PlayerItemModel>();
            foreach(var card in cards)
            {
                var model = new PlayerItemModel { Rank = GetCorrectRank(card.Rank) };
                model.Image = $"./Resource/{card.Suit.ToString().ToLower()}.png";
                values.Add(model);
            }
            Values = values;
        }

        private string GetCorrectRank(int rank)
        {
            if (rank == 11) return "J";
            if (rank == 12) return "Q";
            if (rank == 13) return "K";
            if (rank == 14) return "A";
            return rank.ToString();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class PlayerItemModel
    {
        public string Rank { get; set; }

        public string Image { get; set; }
    }
}
