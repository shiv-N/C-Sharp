//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace Stack
{
    using System;

    /// <summary>
    /// this is Program class for Stack operations.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("****************************Stack Operations*****************************");
            Console.WriteLine("1.Simple Balanced Parentheses \n2.PrimeNumbers\nSelect your options:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BalanceParentheses check = new BalanceParentheses();
                    check.IsBalanceParentheses();
                    break;

                case 2:
                    PrimeNumbers numbers = new PrimeNumbers();
                    numbers.CheckPrime();
                    break;

                default: Console.WriteLine("Invalid Input!!!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
