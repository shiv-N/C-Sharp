//-----------------------------------------------------------------------
// <copyright file="ForgotPassword.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace Common.Models
{
using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// this is class forgotPassword
    /// </summary>
    public class ForgotPassword
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
