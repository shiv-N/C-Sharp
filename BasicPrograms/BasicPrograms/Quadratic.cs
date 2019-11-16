//-----------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// this is Quadratic class.
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quadratic"/> class.
        /// </summary>
        public Quadratic()
        {
            // read input
            Console.WriteLine("Enter value of a , b and c respectively:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            //// creating Utility class object.
            Utility utility = new Utility();
            //// calling Quadratic method.
            utility.Quadratic(a, b, c); 
        }
    }
}
