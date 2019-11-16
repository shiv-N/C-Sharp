//-----------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// this is WindChill class.
    /// </summary>
    public class WindChill
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindChill"/> class.
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="velocity">The velocity.</param>
        public WindChill(double temperature, double velocity)
        {
            //// creating Utility class object.
            Utility utility = new Utility();
            //// calling WindChill method.
            utility.WindChill(temperature, velocity);
        }
    }
}
