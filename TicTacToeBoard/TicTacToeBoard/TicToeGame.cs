using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeBoard
{
    public  class TicToeGame
    {
        public static string computer;
        public static void tictactoeUC1()
        {
            char[] board = new char[10];
            for (int i = 0; i <= board.Length; i ++)
            {
                board[i] = ' ';
            }
        }
        public static void tictactoeUC2()
        {
            
            Console.WriteLine("Select 'X' or 'O': ");
            string player = Console.ReadLine();
            if(player == "X")
            {
                computer = "O";
            }
            else
            {
                computer = "X";
            }
        }
    }
}
