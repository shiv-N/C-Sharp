//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace JUnitPrograms
{
    using System;

    /// <summary>
    /// This is VendingMachine
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendingMachine"/> class.
        /// </summary>
        public VendingMachine()
        {
            Console.WriteLine("Enter money amount:");
            int money = Convert.ToInt32(Console.ReadLine());
            int[] notes = new int[] { 1, 2, 5, 10, 50, 500, 1000 };
            int length = notes.Length;
            Utility utility = new Utility();
            Console.WriteLine("Minimum Notes= " + utility.MinNotes(notes, length, money));
        }
    }
}
