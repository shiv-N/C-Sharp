//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace BasicPrograms
{
    using System;
    using System.Collections.Generic;                       // used two packages.

    /// <summary>
    /// This is Utility Class.
    /// </summary>
    public class Utility
    {
        /******************************************ReplaceString*********************************************************/
        
        /// <summary>
        /// Replaces the string.
        /// </summary>
        /// <param name="string1">The string1.</param>
        /// <param name="string2">The string2.</param>
        public void ReplaceString(string string1, string string2)
        {
            string replacedString = string1.Replace("<<UserName>>", string2);  // string1.Replace replaces two string 
            Console.WriteLine(replacedString);
            //// Console.ReadKey();
        }
        //// end of ReplaceString
 ////****************************************Flip*********************************************************/
 
        /// <summary>
        /// Flips the specified no of times.
        /// </summary>
        /// <param name="noOfTimes">The no of times.</param>
        public void Flip(int noOfTimes)
        {
            int tails = 0, heads = 0;                                                   // initialization of input
            Random random = new Random();                                               // random object made here
            for (int i = 1; i <= noOfTimes; i++)
            {                                                                       //// it iterates for loop and check heads and tails upto given number of time.
                if (random.NextDouble() < 0.5)
                {                                                                      // random function gives random posibilities to toss heads and tails
                    tails++;                                // increment tail count
                }
                else
                {
                    heads++;                                 // increment head count
                }
            }

            Console.Write("tails percentage=");
            Console.WriteLine((double)tails / noOfTimes * 100);                     // calculate percentage of tails
            Console.Write("heads percentage=");
            Console.WriteLine((double)heads / noOfTimes * 100);                      // // calculate percentage of heads
        }
        //// end of Flip

        /// <summary>
        /// Leaps the year.
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>return true if year is leap or false if year is not leap</returns>
/// ****************************************LeapYear*********************************************************/
        public bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {                                                           // A leap year is exactly divisible by 4 except for century years (years ending with 00).
                if (year % 100 == 0)
                {                                                   // The century year is a leap year only if it is perfectly divisible by 400.
                    if (year % 400 == 0)
                    {                                                // only if it is perfectly divisible by 400.
                        return true;                                  // by using modulous(%) it checks if it is divisible or not.
                    }                                              
                        else
                        {
                        return false;
                        }
                    }
                    else
                    {
                    return true;
                    }
            }
            else
            {
                return false;
            }
        }
        //// end of leapYear
        ////******************************Power Of Two************************************************/

        /// <summary>
        /// Power of two.
        /// </summary>
        /// <param name="power">The power of 2</param>
        /// <returns>returns a Power of two value</returns>
        public double PowerOfTwo(int power)
        {
            return Math.Pow(2, power);              // Math.pow function gives power of first position
        }
        //// end of PowerOfTwo
        ////******************************Harmonic Number*********************************************/

        /// <summary>
        /// Harmonics the specified end no.
        /// </summary>
        /// <param name="endNo">The end no.</param>
        /// <returns>double value</returns>
        public double Harmonic(int endNo)
        {
            double sum = 0;
            for (int i = 1; i <= endNo; i++)
            {                                                            // for loop iterates to the given number
                sum = sum + ((double)1 / i);                            // gives series like 1+1/2+1/3+1/4+1/5+1/6+1/7........
            }

            return sum;                                                 // return total value of series
        }
        //// end of harmonic

        ////******************************PrimeFactors*********************************************/        
        
        /// <summary>
        /// Primes the factors.
        /// </summary>
        /// <param name="number">The number.</param>
        public void PrimeFactors(int number)
        {
            Console.Write("Factors=");
            for (int i = 2; i * i <= number; i++)
            {                                                         // for loop iterates to the given number
                while (number % i == 0)
                {                                                    // checking for perfect divisible value
                    Console.Write(i + " ");                          

                    number = number / i;
                }
            }
            //// if number is prime and above 1 then it types the number 
            if (number > 1)
            {
                Console.Write(number);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Finds the triplets.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="length">The length.</param>
        /// end of PrimeFactors
        ////****************************** FindTriplets Program *********************************************/        
        public void FindTriplets(int[] value, int length)
        {
            bool found = false;
            for (int i = 0; i < length - 1; i++)
            {
                //// take hashset for storing the number of list.
                HashSet<int> set = new HashSet<int>();
                for (int j = i + 1; j < length; j++)
                {
                    //// adding two value and string to a variable 
                    int thirdValue = -(value[i] + value[j]);
                    //// check the -ve addition of array value in hashset
                    if (set.Contains(thirdValue))
                    {
                        Console.WriteLine("{" + value[i] + "," + value[j] + "," + thirdValue + "}\n");
                        found = true;
                    }
                    else
                    {                                       //// if -ve element is not present then add second value to the hashset.
                        set.Add(value[j]);
                    }
                }
            }
            //// check for found elemnt.
            if (found == false)
            {
                Console.WriteLine("triplets not exist");
            }
        }

        ////******************************Distance Program*********************************************/
        
        /// <summary>
        /// Origins the distance.
        /// </summary>
        /// <param name="argument1">The argument1.</param>
        /// <param name="argument2">The argument2.</param>
        /// <returns>returns distance value in double type</returns>
        public double OriginDistance(int argument1, int argument2)
        {
            return (double)Math.Sqrt((argument1 * argument1) + (argument2 * argument2));
        }

        ////******************************Check Quadratic Root*********************************************/
        
        /// <summary>
        /// Quadratics the specified a.
        /// </summary>
        /// <param name="a">The a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public void Quadratic(double a, double b, double c)
        {
            double root1, root2;
            double delta = (b * b) - (4 * a * c);
            if (delta > 0)
            {
                root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("the roots of the expression are " + root1 + "and" + root2);
            }
            else if (delta == 0)
            {
                root1 = root2 = -b / (2 * a);
                Console.WriteLine("the roots of the expression are " + root1 + "and" + root1);
            }
            else
            {
                double realValue = -b / (2 * a);
                double imaginaryValue = Math.Sqrt(-delta) / 2 * a;
                Console.WriteLine("the roots of the expression are "
                    + realValue + "+" + imaginaryValue + "i and " + realValue + "+" + imaginaryValue + "i");
            }
        }

        ////****************************** WindChill program ********************************************/
        
        /// <summary>
        /// this is WindChill method 
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="velocity">The velocity.</param>
        public void WindChill(double temperature, double velocity)
        {
            if (Math.Abs(temperature) > 50 || velocity > 120 || velocity < 3)
            {
                Console.WriteLine("As per input the formula is not valid for windchill");
            }
            else
            {
                double windchill = 35.74 + (0.6215 * temperature) + (((0.4275 * temperature) - 35.75) * Math.Pow(velocity, 0.16));
                Console.WriteLine("windchill=" + windchill);
            }
        }
    }
}