using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Media;
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
using System.Windows.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace PongSolo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "/Resources/new_bgm.wav");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainMenu_Loaded(object sender, RoutedEventArgs e)
        {
            sound.PlayLooping();
            this.MinHeight = 500;
            this.MinWidth = 500;
            simulateTab();
        }

        public void simulateTab()
        {
            InputSimulator simu = new InputSimulator();
            simu.Keyboard.KeyPress(VirtualKeyCode.TAB);
        }

        private void playLabel_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                sound.Stop();
                Game newGame = new Game(this);
                newGame.Show();
                this.Hide();
            }
        }

        private void exitButton_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
                App.Current.Shutdown();
        }

        private void leaderboardButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Leaderboard lb = new Leaderboard(this);
                lb.Show();
                this.Hide();
            }
                
        }

        private void gameOverWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }
    }
}
