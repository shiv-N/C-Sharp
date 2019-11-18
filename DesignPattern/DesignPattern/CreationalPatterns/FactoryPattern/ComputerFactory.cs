//-----------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    using System;

    /// <summary>
    /// this is ComputerFactory class.
    /// </summary>
    class ComputerFactory
    {
        /// <summary>
        /// Computers the factory.
        /// </summary>
        /// <param name="type">The type.</param>
        public static void Computer_Factory(string type)
        {
            if (type.Equals("PC"))
            {
                PC pc = new PC();
                Console.WriteLine("PC name is " + pc.Model_Name("DELL"));
            }
            else if (type.Equals("Servers"))
            {
                Servers servers = new Servers();
                Console.WriteLine("Server name is " + servers.Model_Name("Oracle"));
            }
        }
    }
}
