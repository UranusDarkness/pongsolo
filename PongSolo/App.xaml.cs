using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PongSolo
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string connectionString = "SERVER=dicontinued;DATABASE=pong_leaderboard;UID=player;PASSWORD=dicontinued;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
    }
}
