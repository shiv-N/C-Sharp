//-----------------------------------------------------------------------
// <copyright file="IComputers.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.FactoryPattern
{
    /// <summary>
    /// this is IComputers interface
    /// </summary>
    public interface IComputers
    {
        /// <summary>
        /// Models the name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns> it return string value</returns>
        string Model_Name(string name);
    }
}
