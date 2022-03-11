using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PongSolo
{
    class Player
    {
        public string name_player { get; set; }
        public int score_player { get; set; }

        public Player(string n, int s)
        {
            name_player = n;
            score_player = s;
        }
    }
}
