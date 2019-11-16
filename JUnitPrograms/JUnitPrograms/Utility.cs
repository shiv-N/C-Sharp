//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace JUnitPrograms
{
    using System;

    /// <summary>
    /// this is class Utility
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Days the specified method.
        /// </summary>
        /// <param name="m">The m.</param>
        /// <param name="d">The d.</param>
        /// <param name="y">The y.</param>
        /// <returns>returns integer value of day</returns>
        public static int Days(int m, int d, int y)
        {
            int y1 = y - ((14 - m) / 12);
            int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            int m1 = m + (12 * ((14 - m) / 12)) - 2;
            int d1 = (d + x + ((31 * m1) / 12)) % 7;
            return d1;
        }

        /// <summary>
        /// Celsius to fahrenheit.
        /// </summary>
        /// <param name="celsius">The celsius.</param>
        /// <returns>Celsius double value</returns>
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        /// <summary>
        /// Fahrenheit to celsius.
        /// </summary>
        /// <param name="fahrenheit">The fahrenheit.</param>
        /// <returns>fahrenheit's double value</returns>
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        /// <summary>
        /// Monthlies the payment.
        /// </summary>
        /// <param name="p">The p.</param>
        /// <param name="y">The y.</param>
        /// <param name="r">The r.</param>
        /// <returns>Payment's double value</returns>
        public static double MonthlyPayment(double p, double y, double r)
        {
            double n = 12 * y;
            double result = r / (12 * 100);

            return (p * result) / (1 - Math.Pow(1 + r, -n));
        }

        /// <summary>
        /// SQRTs the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>double type of approximate square root value</returns>
        public static double Sqrt(double c)
        {
            if (c < 0)
            {
                return double.NaN;
            }

            double t = c;

            /*while (Math.Abs(t - c / t) > double.Epsilon * t)
            {
                t = ((c / t + t) / 2.0);
            }*/
            t = ((c / t) + t) / 2.0;
            return t;
        }

        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>string type binary value</returns>
        public static string ToBinary(int input)
        {
            string binary = string.Empty;
            while (input > 0)
            {
                int addBinary = input % 2;
                binary = addBinary + string.Empty + binary;
                input = input / 2;
            }

            return binary;
        }

        /// <summary>
        /// Converts to decimal.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>double type decimal value</returns>
        public static double ToDecimal(int input)
        {
            double decimalValue = 0;
            int count = 0;
            while (input > 0)
            {
                int power = input % 10;
                decimalValue += Math.Pow(2, count) * power;
                input = input / 10;
                count++;
            }

            return decimalValue;
        }

        /// <summary>
        /// Minimums the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <param name="length">The length.</param>
        /// <param name="amount">The amount.</param>
        /// <returns>integer value of MinNotes</returns>
        public int MinNotes(int[] notes, int length, int amount)
        {
            if (amount == 0)
            {
                return 0;
            }

            int result = int.MaxValue;

            for (int i = 0; i < length; i++)
            {
                if (notes[i] <= amount)
                {
                    int subResult = this.MinNotes(notes, length, amount - notes[i]);

                    if (subResult != result && subResult + 1 < result)
                    {
                        result = subResult + 1;
                    }
                }
            }

            return result;
        }
    }
}
