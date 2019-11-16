//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// This is Program Class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            validation:
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("1.Replace String \n2.Flip Coin \n3.Leap Year " +
                    "\n4.Harmonic Number \n5.Power of 2 \n6.Prime Factors \n7.2D Array \n8.Exit " +
                    "\n11.calculate Origin-point Distance \n12. Check Quadratic Roots");
                    Console.WriteLine("\nEnter Your Option:");
                    int option = Convert.ToInt32(Console.ReadLine());       // converting string value to int
                    //// switch case for accessing block of program in given cases. 
                    switch (option)
                    {
                        case 1:
                                //// create replacestring class object to accessing replaceString class. 
                                ReplaceString replaceString = new ReplaceString();
                                break;

                        case 2:
                                //// create FlipCoin class object to accessing FlipCoin class. 
                                FlipCoin flip = new FlipCoin();
                                flip.CoinFlipped();
                                break;

                        case 3:
                                //// create LeapYear class object to accessing LeapYear class. 
                                LeapYear year = new LeapYear();
                                year.Leap();
                                break;
                        case 4:
                                //// create Harmonic class object to accessing Harmonic class. 
                                Harmonic harmonic = new Harmonic();
                                break;
                        case 5:
                                //// create PoweofTwo class object to accessing PowerofTwo class. 
                                PowerOfTwo power = new PowerOfTwo(args[0]);
                                break;
                        case 6:
                                //// create Factors class object to accessing Factors class. 
                                Factors prime = new Factors();
                                break;
                        case 7:
                                //// create ObjectDArray class object to accessing ObjectDArray class. 
                                ObjectDArray array = new ObjectDArray();
                                break;
                        case 9:
                                //// create MultiDArray class object to accessing MultiDArray class. 
                                MultiDArray array1 = new MultiDArray();
                                break;
                        case 10:
                                //// create FindTriplets class object to accessing FindTriplets class. 
                                FindTriplets triplets = new FindTriplets();
                                break;
                        case 11:
                                //// converting argument to integer
                                int x = Convert.ToInt32(args[1]); 
                                int y = Convert.ToInt32(args[2]);
                                //// create distance class object to accessing distance class. 
                                Distance distance = new Distance(x, y);
                                break;
                        case 12:
                                //// create Quadratic class object to accessing Quadratic class. 
                                Quadratic quadratic = new Quadratic();
                                break;
                        case 13:
                                //// converting argument to double
                                double temperature = Convert.ToDouble(args[3]);
                                double velocity = Convert.ToDouble(args[4]);
                                //// create WindChill class object to accessing WindChill class.
                                WindChill wind = new WindChill(temperature, velocity);
                                break;
                        case 8:
                                //// flag tends to false for breaking while loop.
                                flag = false;
                                break;
                        default:
                                Console.WriteLine("Wrong option! please enter option again.");
                                break;
                    }
                }
            }
            catch (Exception)
            {                                                     //// check for excepton and give the message to console
                Console.WriteLine("Please Enter valid Input");
                //// by using goto the excusion starts from validation1 label.
                goto validation;
            }
            //// holds the console.
            Console.ReadKey();
        }
    }
}