using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PongSolo
{
    /// <summary>
    /// Logica di interazione per Game.xaml
    /// </summary>
    public partial class Game : Window
    {      
        SoundPlayer wall_sfx = new System.Media.SoundPlayer(Environment.CurrentDirectory + "/Resources/wall_bounce.wav");
        SoundPlayer rect_sfx = new System.Media.SoundPlayer(Environment.CurrentDirectory + "/Resources/rect_bounce.wav");
        DispatcherTimer playerDispatcher = new DispatcherTimer();
        DispatcherTimer ballDispatcher = new DispatcherTimer();

        MainWindow temp;

        public int score = 0;

        double startxspeed = 3;
        double startyspeed = 3;
        int actualspeed = 0;
        int oldspeed = 0;
        public Game(MainWindow mw)
        {
            temp = mw;
            InitializeComponent();
            playerDispatcher.Interval = TimeSpan.FromMilliseconds(10);
            ballDispatcher.Interval = TimeSpan.FromMilliseconds(1);
            ballDispatcher.Tick += ballMovement;
            playerDispatcher.Tick += playerMovement;
            playerDispatcher.Start();
            ballDispatcher.Start();
        }

        public int getScore()
        {
            return score;
        }

        private void ballMovement(object sender, EventArgs e)
        {
            moveBall();

            Rect player = new Rect(Canvas.GetLeft(superRect), Canvas.GetTop(superRect), superRect.ActualWidth, superRect.ActualHeight);
            Rect ball = new Rect(Canvas.GetLeft(superElly), Canvas.GetTop(superElly), superElly.ActualWidth, superElly.ActualHeight);
           
            if (Canvas.GetLeft(superElly) <= 0 || Canvas.GetLeft(superElly) >= superCanvas.ActualWidth -20)
            {
                startxspeed *= -1;
                wall_sfx.Play();
            }               
            if (Canvas.GetTop(superElly) <= 0)
            {
                startyspeed *= -1;
                wall_sfx.Play();
            }
                
            if (Canvas.GetTop(superElly) >= superCanvas.ActualHeight)
                GameOverSplash();

            if (player.IntersectsWith(ball))
            {
                rect_sfx.Play();
                score++;
                actualspeed++;
                scoreLabel.Content = "Punteggio: " + score.ToString();
                startyspeed *= -1;
            }

        }

        public void moveBall()
        {
            if (actualspeed - oldspeed == 25)
            {
                oldspeed = actualspeed;
                if (startxspeed < 0)
                    startxspeed--;
                else
                    startxspeed++;

                if (startyspeed < 0)
                    startyspeed--;
                else
                    startyspeed++;
            }
            Canvas.SetLeft(superElly, Canvas.GetLeft(superElly) + startxspeed);
            Canvas.SetTop(superElly, Canvas.GetTop(superElly) + startyspeed);
        }

        private void playerMovement(object sender, EventArgs e)
        {
            double xvalue = Canvas.GetLeft(superRect) + 3;

            if (Keyboard.IsKeyDown(Key.Left))
            {
                if (!outOfBoundaries("left"))
                    MovePlayerLeft();
            }              
            if (Keyboard.IsKeyDown(Key.Right))
            {
                if (!outOfBoundaries("right"))
                    MovePlayerRight();
            }                   
        }

        public bool outOfBoundaries(string s)
        {
            bool is_out_of_boundaries = false;
            switch (s)
            {
                case "left":
                    {
                        if (Canvas.GetLeft(superRect) <= 0)
                            is_out_of_boundaries = true;
                        break;
                    }                 
                case "right":
                    {
                        if (Canvas.GetLeft(superRect) >= superCanvas.ActualWidth-superRect.Width)
                            is_out_of_boundaries = true;
                        break;
                    }
                    
                default:
                    break;
            }
            return is_out_of_boundaries;
        }

        private void MovePlayerRight()
        {
            Canvas.SetLeft(superRect, Canvas.GetLeft(superRect) + 5);
        }

        private void MovePlayerLeft()
        {
            Canvas.SetLeft(superRect, Canvas.GetLeft(superRect) - 5);
        }

        private void Game_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            App.connection.Close();
            App.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.MinHeight = 300;
            this.MinWidth = 300;
            Canvas.SetTop(superRect, superCanvas.ActualHeight -15);
            
        }

        private void GameOverSplash()
        {
            playerDispatcher.Stop();
            ballDispatcher.Stop();
            gameOverWindow rip = new gameOverWindow(score, temp);
            this.Hide();
            rip.Show();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            Canvas.SetTop(superRect, superCanvas.ActualHeight - 15);
        }
    }
}
