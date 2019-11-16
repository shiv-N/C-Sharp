//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace JUnitPrograms
{
    using System;

    /// <summary>
    /// this is class TemperatureConversion
    /// </summary>
    public class TemperatureConversion
    {
        /// <summary>
        /// Conversion, this is instance.
        /// </summary>
        public static void Conversion()
        {
            Console.WriteLine("\nEnter your option:\n1.Celsius To Fahrenheit\n2.Fahrenheit To Celsius");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                        Console.WriteLine("Enter value in Celsius:");
                        double celsius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Celsius To Fahrenheit: " + Utility.CelsiusToFahrenheit(celsius));
                        break;
                case 2:
                        Console.WriteLine("Enter value in Fahrenheit:");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Fahrenheit To Celsius: " + Utility.FahrenheitToCelsius(fahrenheit));
                        break;
                default: Console.WriteLine("Wrong option!!!");
                    break;
            }
        }
    }
}
