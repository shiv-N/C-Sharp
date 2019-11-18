//-----------------------------------------------------------------------
// <copyright file="Volts.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Adapter_Design_Pattern
{
    /// <summary>
    /// this is class Volts
    /// </summary>
    public class Volts
    {
        /// <summary>
        /// Gets or sets the volt.
        /// </summary>
        /// <value>
        /// The volt.
        /// </value>
        private int Volt { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volts"/> class.
        /// </summary>
        /// <param name="volt">The volt.</param>
        public Volts(int volt)
        {
            this.Volt = volt;
        }

        /// <summary>
        /// Getvolts this instance.
        /// </summary>
        /// <returns>this.volts</returns>
        public int Getvolts()
        {
            return this.Volt;
        }
    }
}
