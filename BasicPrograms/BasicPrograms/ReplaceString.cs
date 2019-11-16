//-----------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BasicPrograms
{
    using System;

    /// <summary>
    /// This is ReplaceString Class.
    /// </summary> 
    public class ReplaceString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceString"/> class.
        /// </summary>
        public ReplaceString()
        {
            string template = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Enter Your Name:");
            string newString = Console.ReadLine();
            Utility utility = new Utility();
            utility.ReplaceString(template, newString);
        }
    }
}