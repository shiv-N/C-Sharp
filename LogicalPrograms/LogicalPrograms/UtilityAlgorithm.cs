//-----------------------------------------------------------------------
// <copyright file="UtilityAlgorithm.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace LogicalPrograms
{
    using System;

    /// <summary>
    /// this is UtilityAlgorithm class.
    /// </summary>
    public class UtilityAlgorithm
    {
        /// <summary>
        /// this is IterativePermutation method. it gives permutation by sing iterative method.
        /// </summary>
        public static void IterativePermutation()
        {
        }

        /// <summary>
        /// this is recursivePermutation method. it gives permutation by sing recursive method.
        /// </summary>
        public static void RecursivePermutation()
        {
        }

        /// <summary>
        /// Gambles the specified stake.
        /// </summary>
        /// <param name="stake">The stake.</param>
        /// <param name="goal">The goal.</param>
        /// <param name="noOfTurns">The no ofTurns.</param>
        public void Gamble(int stake, int goal, int noOfTurns)
        {
            Random random = new Random();
            int win = 0, loss = 0;
            for (int n = 0; n < noOfTurns; n++)
            {
                while (stake > 0 && stake < goal)
                {
                    if (random.NextDouble() > 0.5)
                    {
                        stake++;
                    }
                    else
                    {
                        stake--;
                    }
                }

                if (stake == goal)
                {
                    win++;
                    stake = 10;
                }
                else if (stake == 0)
                {
                    loss++;
                    stake = 10;
                }
            }

            double percentageWin = (double)win / noOfTurns * 100;
            double percentageloss = (double)loss / noOfTurns * 100;
            Console.WriteLine("wins " + win + " percentage of win=" + percentageWin);
            Console.WriteLine("loss " + loss + " percentage of loss:" + percentageloss);
        }

        ////*****************************************************TicTacToe Utility Methods starts from here******************************************************/////        
   
        /// <summary>
        /// Initialize the specified board.
        /// </summary>
        /// <param name="board">The board.</param>
        public void Initialize(char[,] board)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = (char)(count++ + '0');
                }
            }
        }

        /// <summary>
        /// Displays the specified board.
        /// </summary>
        /// <param name="board">The board.</param>
        public void Display(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" " + board[i, j]);
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Replaces the specified element of board.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="choice">The choice.</param>
        /// <param name="player1Marker">The player1 marker.</param>
        /// <returns> boolean value </returns>
        public bool Replace(char[,] board, char choice, char player1Marker)
        {
            bool valid = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == choice)
                    {
                        board[i, j] = player1Marker;
                        valid = true;
                        return valid;
                    }
                }
            }

            return valid;
        }

        /// <summary>
        /// checks the win.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns>boolean value </returns>
        public bool WinCheck(char[,] board)
        {
            UtilityAlgorithm game = new UtilityAlgorithm();
            return game.CheckRow(board) || game.CheckColumn(board) || game.CheckDiagonal(board);
        }

        /// <summary>
        /// Checks the row.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns> boolean value </returns>
        public bool CheckRow(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks the column.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns>boolean value </returns>
        public bool CheckColumn(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks the diagonal.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns> boolean value </returns>
        public bool CheckDiagonal(char[,] board)
        {
            if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) || (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
