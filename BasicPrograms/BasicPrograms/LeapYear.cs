//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// This is LeapYear Class.
    /// </summary>
   public class LeapYear
   {
        /// <summary>
        /// this is instance leap.
        /// </summary>
        public void Leap()
        {
            validation:
            try
            {
                Console.WriteLine("enter a year(only 4 digits:)");
                int year = Convert.ToInt32(Console.ReadLine());     // converting string value to int
                Utility utility = new Utility();
                bool result = utility.LeapYear(year);
                if (result)
                {
                    Console.WriteLine("this is leap year");
                }
                else
                {
                    Console.WriteLine("this is not leap year");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("WRONG INPUT\nPlease right input again");
                goto validation;
            }
        }
   }
}