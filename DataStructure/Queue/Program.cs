//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace Queue
{
    using System;

    /// <summary>
    /// this is main program class for Queue operations
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("1. CashCounter \n2.Calender");
            Console.WriteLine("enter your option:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CashCounter checkOne = new CashCounter();
                    checkOne.Queue();
                    break;

                case 2:
                    Calender checkTwo = new Calender();
                    checkTwo.GetCalender();
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.ReadKey();
            //CalenderQueue check = new CalenderQueue();
            //check.GetCalender();
        }
    }
}
