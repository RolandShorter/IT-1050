using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
   public class Player
    {
        public const char PLAYER_SYMBOL = 'x';
        public const char SPACE = ' ';
        public static char[,] players;
        
        public Player()
        {
            players = new char[Board.Dimension, Board.Dimension];
        }
    }
}
