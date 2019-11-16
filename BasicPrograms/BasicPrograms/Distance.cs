//-----------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;
    
    /// <summary>
    /// this is class Distance.
    /// </summary>
    public class Distance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Distance"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Distance(int x, int y)
        {
            //// creating Utility class object.
            Utility utility = new Utility();
            //// calling OriginDistance method and store return data in variable
            double pointdistance = utility.OriginDistance(x, y);
            Console.WriteLine("Distance between (0,0) and (" + x + "," + y + ")= " + pointdistance);
        }
    }
}
