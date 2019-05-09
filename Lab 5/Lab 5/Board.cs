using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Board
    {
        private string[,] board;
        public const int Dimension = 8;

        private Player player;
        private Move move;

        public Board()
        {
            player = new Player();
            move = new Move();
            board = new string[Dimension, Dimension];
            BoardxSymbol = "+---";
            BoardySymbol = "| ";
        }
        
        public string BoardxSymbol { get; set; }
        public string BoardySymbol { get; set; }

        
    }
}
