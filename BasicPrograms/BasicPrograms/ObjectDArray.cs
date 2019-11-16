//-----------------------------------------------------------------------
// <copyright file="ObjectDArray.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace BasicPrograms
{
    using System;

    /// <summary>
    /// this is ObjectDArray class.
    /// </summary>
    public class ObjectDArray
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDArray"/> class.
        /// </summary>
        public ObjectDArray()
        {
            //// created jugged object array to store different type of element in each row/element of array 
            object[][] array = new object[4][];
            array[0] = new object[4];
            array[1] = new object[5];
            array[2] = new object[6];
            array[3] = new object[4];

            Console.WriteLine("Enter four intger:");
            for (int i = 0; i < 4; i++) 
            {
                array[0][i] = Convert.ToInt32(Console.ReadLine()); 
            }

            Console.WriteLine("Enter four doubles:");
            for (int i = 0; i < 5; i++)
            {
                array[1][i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter four boolean value:");
            for (int i = 0; i < 6; i++)
            {
                array[2][i] = Convert.ToBoolean(Console.ReadLine());
            }

            Console.WriteLine("Enter four String:");
            for (int i = 0; i < 4; i++)
            {
                array[3][i] = Console.ReadLine();
            }
            //// iterating jugged array
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }

                Console.WriteLine();
            }
            //// holds the console.
            Console.ReadKey();
        }
    }
}
