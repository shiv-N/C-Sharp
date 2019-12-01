//-----------------------------------------------------------------------
// <copyright file="FundooModels.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    /// <summary>
    /// this is class FundooModels
    /// </summary>
    public class FundooModels
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the user address.
        /// </summary>
        /// <value>
        /// The user address.
        /// </value>
        public string UserAddress { get; set; }

        /// <summary>
        /// Gets or sets the token.
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        public string Token { get; set; }
    }
}