using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Board
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

        public void  displayBoard()
        {
            while(!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");

                for (int r = 0; r < Dimension; r++)
                {
                    Console.Write("  ");
                    for (int c = 0; c < Dimension; c++)
                    {
                        Console.Write(BoardxSymbol);

                    }
                    Console.
                        Write("+\n");
                    for (int c = 0; c < Dimension; c++)
                    {
                        Console.Write(r + " ");
                        Console.Write(BoardySymbol + Player.players[r, c] + " ");
                    }

                    Console.Write("|\n");
                }
            }
        }

    }
}
