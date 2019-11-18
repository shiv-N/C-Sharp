//-----------------------------------------------------------------------
// <copyright file="Eager_Initialize.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern
{
    using System;

    /// <summary>
    /// this is sealed class Eager_Initialize.
    /// </summary>
    public sealed class Eager_Initialize
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static readonly Eager_Initialize instance = new Eager_Initialize();

        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="Eager_Initialize"/> class from being created.
        /// </summary>
        private Eager_Initialize()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>returns instance </returns>
        public static Eager_Initialize GetInstance()
        {
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
