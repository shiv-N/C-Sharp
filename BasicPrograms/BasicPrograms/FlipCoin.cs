//-----------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// This is FlipCoin Class.
    /// </summary> 
    public class FlipCoin
    {
        /// <summary>
        /// Method to check Coins flipped.
        /// </summary>
        public void CoinFlipped()
        {
            Console.WriteLine("Enter a no. of times coin to be fliped:");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());            // converting string value to int
            Utility utility = new Utility();
            utility.Flip(noOfTimes);
        }
    }
}