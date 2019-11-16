//-----------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace JUnitPrograms
{
    using System;

    /// <summary>
    /// this is DayOfWeek
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// Days the specified month.
        /// </summary>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="year">The year.</param>
        public static void Days(int month, int day, int year)
        {
            string[] days = { "sunday", "monday", "tuesday", "wednesday", "thursday", "friday", "saturday" };
            int dayIndex = Utility.Days(month, day, year);
            Console.WriteLine("day= " + days[dayIndex]);
        }
    }
}
