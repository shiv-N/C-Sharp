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

namespace FundooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount account;
        public AccountController(IAccount account)
        {
            this.account = account;
        }
        [HttpPost]
        public IActionResult Register(FundooModels model)
        {
            return Ok(this.account.Register(model));
        }
        [Route("login")]
        [HttpPost]
        public IActionResult Login(FundooModels model)
        {
            FundooModels validModel= account.Login(model);
            if (validModel.Email == null)
            {
                return Ok("Invalid login Id or Password.");
            }
            else
            {
                return Ok(validModel);
            }
        }
        [HttpGet,Authorize]
        public IEnumerable<FundooModels> GetAllEmployee()
        {
            throw new NotImplementedException();
        }
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
        [Route("reset")]
        [HttpPost]
        public IActionResult ResetPassword(ResetModel token)
        {
            return Ok(account.ResetPassword(token));
        }
    }
}