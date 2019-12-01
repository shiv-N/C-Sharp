//-----------------------------------------------------------------------
// <copyright file="IAccount.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace BusinessManager.Interface
{
    using Common;
    using Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// this is interface IAccount
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        string Register(FundooModels model);

        /// <summary>
        /// Logins the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string Login(FundooModels model);
        //public IEnumerable<FundooModels> GetAllEmployee();

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string ForgotPassword(ForgotPassword model);

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public string ResetPassword(ResetModel token);
    }
}
