//-----------------------------------------------------------------------
// <copyright file="Singleton_Structure.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern
{
    using System;

    /// <summary>
    /// this is Singleton_Structure
    /// </summary>
    sealed class Singleton_Structure
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static Singleton_Structure instance;

        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="Singleton_Structure"/> class from being created.
        /// </summary>
        private Singleton_Structure()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static Singleton_Structure GetInstance()
        {
            
            if (instance == null)
            {
                instance = new Singleton_Structure();
            }
            return instance;

        }

        /// <summary>
        /// Instances the specified input.
        /// </summary>
        /// <param name="input">The input.</param>
        public void Instance(string input)
        {
            Console.WriteLine(input);
        }
    }
}
