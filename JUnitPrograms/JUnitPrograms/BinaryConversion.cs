//-----------------------------------------------------------------------
// <copyright file="binaryConversion.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace JUnitPrograms
{
    using System;

    /// <summary>
    /// this is BinaryConversion
    /// </summary>
    public class BinaryConversion
    {
        /// <summary>
        /// Converts to binary.
        /// </summary>
        public static void ToBinary()
        {
            Console.WriteLine("Enter input for conversion of binary:");
            int input = Convert.ToInt32(Console.ReadLine());
            string binary = Utility.ToBinary(input);
            Console.WriteLine("Binary value:" + binary);

            string string1 = binary.Substring(0, binary.Length / 2);
            string string2 = binary.Substring(binary.Length / 2, binary.Length - (binary.Length / 2));
            Console.WriteLine(string1);
            Console.WriteLine(string2);
            Console.WriteLine(Convert.ToInt32(string2 + string1));
            double newBinay = Utility.ToDecimal(Convert.ToInt32(string2 + string1));
            Console.WriteLine("After Swapping nibble the new value: " + newBinay);
        }
    }
}
