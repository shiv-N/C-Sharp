//-----------------------------------------------------------------------
// <copyright file="ResetModel.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace Common.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// this is class ResetModel
    /// </summary>
    public class ResetModel
    {
        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        [Required]
        public string token { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        public string password { get; set; }
    }
}
