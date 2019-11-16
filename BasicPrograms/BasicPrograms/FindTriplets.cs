//-----------------------------------------------------------------------
// <copyright file="FindTriplets.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// this is FindTriplets class
    /// </summary>
    public class FindTriplets
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindTriplets"/> class.
        /// </summary>
        public FindTriplets()
        {
            Console.WriteLine("Enter length of an array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] values = new int[length];
            Console.WriteLine("Enter value for array:");
            for (int i = 0; i < 5; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            //// creating Utility class object.
            Utility utility = new Utility();
            //// calling FindTriplets method.
            utility.FindTriplets(values, length);
        }
    }
}
