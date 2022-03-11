using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsInput;
using WindowsInput.Native;

namespace PongSolo
{
    /// <summary>
    /// Logica di interazione per gameOverWindow.xaml
    /// </summary>
    public partial class gameOverWindow : Window
    {
        SoundPlayer gameover_sfx = new System.Media.SoundPlayer(Environment.CurrentDirectory + "/Resources/game_over.wav");
        MainWindow tempwindow;
        int tempsco;
        public gameOverWindow(int sco, MainWindow menu)
        {
            tempwindow = menu;
            tempsco = sco;
            InitializeComponent();
        }

        private void gameOverWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }

        private void GOverWindow_Loaded(object sender, RoutedEventArgs e)
        {
            gameover_sfx.Play();
            simulateTab();
            scoreLabel.Content = "Score: " + tempsco.ToString();
        }

        public void simulateTab()
        {
            InputSimulator simu = new InputSimulator();
            simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }

        private void namePlayer_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9A-Za-z]+").IsMatch(e.Text);
        }

        private void saveLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Tab)
                saveLabel.IsSelected = true;
            if (e.Key == Key.Enter &&saveLabel.IsSelected)
            {
                string registerQuery = "INSERT INTO top_player(name, score) VALUES (@name, @score)";
                MySqlCommand command = new MySqlCommand(registerQuery, App.connection);
                command.Parameters.AddWithValue("@name", namePlayer.Text);
                command.Parameters.AddWithValue("@score", tempsco);
                command.Prepare();
                command.ExecuteNonQuery();
                tempwindow.Show();
                this.Hide();
            }
        }

        private void mainMenuLabel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Tab)
                mainMenuLabel.IsSelected = true;
            if (e.Key == Key.Enter && mainMenuLabel.IsSelected)
            {
                tempwindow.Show();
                this.Hide();
            }
        }
    }
}
