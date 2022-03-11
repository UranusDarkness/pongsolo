using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PongSolo
{
    /// <summary>
    /// Logica di interazione per Leaderboard.xaml
    /// </summary>
    public partial class Leaderboard : Window
    {
        MainWindow parentWindow;
        public Leaderboard(MainWindow parent)
        {
            parentWindow = parent;
            InitializeComponent();

            

        }

        private void LeaderboardWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }

        private void leaderboardWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
                menuLabel.IsSelected = true;
            if (e.Key == Key.Enter)
            {
                if(menuLabel.IsSelected)
                {
                    parentWindow.Show();
                    this.Hide();
                }    
            }
        }

        private void leaderboardWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.MinHeight = this.ActualHeight;
            this.MinWidth = this.ActualWidth;
            List<Player> playerList = new List<Player>();
            string sqlquery = "SELECT * FROM top_player";
            MySqlCommand command = new MySqlCommand(sqlquery, App.connection);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Player tempPlayer = new Player(dataReader.GetString(0), dataReader.GetInt32(1));
                playerList.Add(tempPlayer);
            }

            List<Player> topTenPlayers = playerList.OrderByDescending(x => x.score_player).ToList();
            if(topTenPlayers.Count > 10)
              topTenPlayers.RemoveRange(10, topTenPlayers.Count - 10);

            dataGridLeaderboard.ItemsSource = topTenPlayers;
            dataReader.Close();
        }
    }
}
