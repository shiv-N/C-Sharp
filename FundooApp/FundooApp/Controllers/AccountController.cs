using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessManager.Interface;
using Common;

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

    }
}