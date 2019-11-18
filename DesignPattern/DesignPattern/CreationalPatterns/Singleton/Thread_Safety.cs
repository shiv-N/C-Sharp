//-----------------------------------------------------------------------
// <copyright file="Thread_Safety.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern
{
    using System;

    /// <summary>
    /// this is class thread safety.
    /// </summary>
    class Thread_Safety
    {
        /// <summary>
        /// The object
        /// </summary>
        private static readonly object obj = new object();

        /// <summary>
        /// The instance
        /// </summary>
        private static Thread_Safety instance;

        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// Prevents a default instance of the <see cref="Thread_Safety"/> class from being created.
        /// </summary>
        private Thread_Safety()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static Thread_Safety GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if(instance == null)
                    {
                        instance = new Thread_Safety();
                    }
                }
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
