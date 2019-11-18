//-----------------------------------------------------------------------
// <copyright file="Servers.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------

namespace DesignPattern.FactoryPattern
{
    /// <summary>
    /// this is class server implementing IComputers
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryPattern.IComputers" />
    public class Servers : IComputers
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Models the name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>
        /// it return string value
        /// </returns>
        public string Model_Name(string name)
        {
            this.name = name;
            return this.name;
        }
    }
}
