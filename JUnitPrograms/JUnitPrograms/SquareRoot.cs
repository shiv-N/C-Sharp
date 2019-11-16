//-----------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace JUnitPrograms
{
    using System;

    /// <summary>
    /// this is class SquareRoot
    /// </summary>
    public class SquareRoot
    {
        /// <summary>
        /// SQRT is the instance of class.
        /// </summary>
        public static void Sqrt()
        {
            Console.WriteLine("Enter input for Square Roots:");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Approx Square Root:" + Utility.Sqrt(input));
        }
    }
}
