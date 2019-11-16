//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace OOPS
{
    using System;

    /// <summary>
    /// this is class Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            bool valid = false;
            // while loop iterare until valid is false.
            while (!valid)
            {
                try
                {
                    // options
                    Console.WriteLine("1.Inventory Management\n2.Replace String\n3.Stock Management\n4.Exit\nEnter your option:");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            // create obj of inventory test
                            Inventory test = new Inventory();
                            // calls the method JsonDeserilaize.
                            test.JsonDeserilaize();
                            break;
                        case 2:
                            // create obj of Replace
                            Replace replace = new Replace();
                            replace.ReplaceStringElements();
                            break;
                        case 3:
                            // create obj of Stock
                            Stock stock = new Stock();
                            stock.Stock_Management();
                            break;
                        case 4:
                            valid = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Output!!");
                            break;

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid input!!,it throw exception..\n"+e);
                }
            }
            Console.ReadKey();
        }
    }
}
