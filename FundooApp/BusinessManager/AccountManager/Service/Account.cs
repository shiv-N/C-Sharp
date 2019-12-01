﻿//-----------------------------------------------------------------------
// <copyright file="Account.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace BusinessManager
{
    using BusinessManager.Interface;
    using Common;
    using Common.Models;
    using FundooRepository.Interface;

    /// <summary>
    /// this is class Account
    /// </summary>
    /// <seealso cref="BusinessManager.Interface.IAccount" />
    public class Account : IAccount
    {
        /// <summary>
        /// The account
        /// </summary>
        IAccountRepository account;

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public Account(IAccountRepository account)
        {
            this.account = account;
        }

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string Register(FundooModels model)
        {
            if(model != null)
            {
                return this.account.Register(model);
            }
            else
            {
                return "Insufficients details....";
            }
        }

        /// <summary>
        /// Logins the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string Login(FundooModels model)
        {
            if (model != null)
            {
                string token = account.Login(model);
                if (token != string.Empty)
                {
                    return "Login successful!!";
                }
                else
                {
                    return "Invalid credentials";
                }
            }
            else
            {
                return "Invalid credentials";
            }
        }

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string ForgotPassword(ForgotPassword model)
        {
            return account.ForgotPassword(model);
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns></returns>
        public string ResetPassword(ResetModel token)
        {
            return account.ResetPassword(token);
        }
    }
}
