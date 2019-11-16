//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace LogicalPrograms
{
    using System;

    /// <summary>
    /// this is main Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            validation:
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1.Gambling Problem \n2.Coupon collector \n3.Stopwatch \n4.play TicTacToe \n5.exit");
                    Console.WriteLine("\nEnter Your Option:");
                    int option = Convert.ToInt32(Console.ReadLine());       // converting string value to int

                    switch (option)
                    {
                        case 1: Gambler gambler = new Gambler();
                            break;

                        case 2: Coupons coupon = new Coupons();
                            break;

                        case 3:
                            Stopwatches stopwatch = new Stopwatches();
                            break;

                        case 4:
                            Game game = new Game();
                            game.PlayGame();
                            break;

                        case 5: flag = false;
                            break;

                        default:
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter valid Input");
                goto validation;
            }

            Console.ReadKey();
        }
    }
}
