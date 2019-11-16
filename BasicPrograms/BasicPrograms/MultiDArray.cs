//-----------------------------------------------------------------------
// <copyright file="MultiDArray.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// this is MultiDArray class.
    /// </summary>
    public class MultiDArray
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiDArray"/> class.
        /// </summary>
        public MultiDArray()
        {
            //// create object multidimensional array
            object[,] array = new object[4, 4];
            Console.WriteLine("Enter four intger:");
            for (int i = 0; i < 4; i++)
            {
                array[0, i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter four doubles:");
            for (int i = 0; i < 4; i++)
            {
                array[1, i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter four boolean value:");
            for (int i = 0; i < 4; i++)
            {
                array[2, i] = Convert.ToBoolean(Console.ReadLine());
            }

            Console.WriteLine("Enter four String:");
            for (int i = 0; i < 4; i++)
            {
                array[3, i] = Console.ReadLine();
            }
            //// iterate array and print it
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
