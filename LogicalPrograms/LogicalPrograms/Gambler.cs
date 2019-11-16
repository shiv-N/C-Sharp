//-----------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace LogicalPrograms
{
    using System;

    /// <summary>
    /// this is gambler class.
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gambler"/> class.
        /// </summary>
        public Gambler()
        {
        Console.WriteLine("enter stakes:");
        int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter goal:");
        int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of turns:");
        int noOfturns = Convert.ToInt32(Console.ReadLine());
            UtilityAlgorithm utility = new UtilityAlgorithm();
            utility.Gamble(stake, goal, noOfturns);
        }
    }
}
