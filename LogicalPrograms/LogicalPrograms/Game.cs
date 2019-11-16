//-----------------------------------------------------------------------
// <copyright file="Game.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace LogicalPrograms
{
    using System;

    /// <summary>
    /// this is Game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// this is PlayGame
        /// </summary>
        public void PlayGame()
        {
            //// initialize the variable
            int count = 0, intChoice;
            char choice, player1Marker, player2Marker;
            bool isWin = false;
            //// create 3*3 char multidimension array
            char[,] board = new char[3, 3];
            //// create random object 
            Random random = new Random();
            //// create game object
            UtilityAlgorithm game = new UtilityAlgorithm();

            Console.WriteLine("Enter player 1 name: ");
            string player1 = Console.ReadLine();
            Console.WriteLine("player 2 is Computer.");

            validation1:
            try
            {
                //// take input choice in char type
                Console.WriteLine(player1 + " enter your choice marker for the game 'x' or '$':");
                player1Marker = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Choice");
                goto validation1;
            }
            //// assign player's marker to player
            if (player1Marker == 'X' || player1Marker == 'x')
            {
                player2Marker = '$';
            }
            else
            {
                player2Marker = 'X';
            }
            //// declare the array 
            game.Initialize(board);
            game.Display(board);
            //// do while loop for executing 1st iteration without any condition
            do
            {
                ////Block-1
                validation2:
                try
                {
                    Console.WriteLine("Now, select your choice:");
                    intChoice = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Choice");
                    goto validation2;
                }

                if (intChoice >= 48 && intChoice <= 56)
                {
                    choice = Convert.ToChar(intChoice);
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                    goto validation2;
                }

                bool valid = game.Replace(board, choice, player1Marker);
                if (!valid)
                {
                    Console.WriteLine("Invalid Choice");
                    goto validation2;
                }

                game.Display(board);

                isWin = game.WinCheck(board);
                if (isWin)
                {
                    Console.Write("we have winner: " + player1);
                    break;
                }

                count++;
                if (count == 5)
                {
                    Console.WriteLine("****Draw****");
                    break;
                }

                ////Block-2
                validation3:
                Console.WriteLine("Computer's turn:");
                int computerChoice = (int)random.Next(9);
                Console.WriteLine(computerChoice);
                char computerChoose = (char)(computerChoice + '0');
                bool computerValid = game.Replace(board, computerChoose, player2Marker);
                if (!computerValid)
                {
                    // Console.WriteLine("Invalid Choice");
                    goto validation3;
                }

                game.Display(board);
                isWin = game.WinCheck(board);
                if (isWin)
                {
                    Console.Write("we have winner: computer");
                    break;
                }
            }
            while (isWin == false || count < 5);
            Console.ReadKey(); 
        }
    }
}
