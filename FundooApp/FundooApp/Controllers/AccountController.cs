//-----------------------------------------------------------------------
// <copyright file="AccountController.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace FundooApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using BusinessManager.Interface;
    using Common;
    using Microsoft.AspNetCore.Authorization;
    using Common.Models;

    /// <summary>
    /// this claa AccountController
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// this is account
        /// </summary>
        private readonly IAccount account;

        /// <summary>
        /// this is method AccountController
        /// </summary>
        /// <param name="account"></param>
        public AccountController(IAccount account)
        {
            this.account = account;
        }

        /// <summary>
        /// this is method Register
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(FundooModels model)
        {
            return Ok(this.account.Register(model));
        }

        /// <summary>
        /// this is method Login
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("login")]
        [HttpPost]
        public IActionResult Login(FundooModels model)
        {
            return Ok(account.Login(model));
           
        }

        /// <summary>
        /// this is method  GetAllEmployee
        /// </summary>
        /// <returns></returns>
        [HttpGet,Authorize]
        public IEnumerable<FundooModels> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// this is mehtod ForgotPassword
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("forgot")]
        [AllowAnonymous]
        public IActionResult ForgotPassword(ForgotPassword model)
        {
            string userToken = account.ForgotPassword(model);
            if (userToken != string.Empty)
            {
                var passwordRestLink = Url.Action("ResetPassword", "Account",
                    new { email = model.Email, token = userToken }, Request.Scheme);
                return Ok(userToken);
            }
            else
            {
                return Ok("Invalid email");
            }
        }

        /// <summary>
        /// this is method ResetPassword
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [Route("reset")]
        [HttpPost]
        public IActionResult ResetPassword(ResetModel token)
        {
            return Ok(account.ResetPassword(token));
        }
    }
}