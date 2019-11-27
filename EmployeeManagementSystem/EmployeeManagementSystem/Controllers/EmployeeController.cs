using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLibrary.Interface;
using CommonLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBL employeeBL;
        public EmployeeController(IEmployeeBL employeeBL)
        {
              this.employeeBL = employeeBL;
     
        }

        [HttpPost]    
        public IActionResult Register(ModelCL model)
        {
            return Ok(this.employeeBL.Register(model));
        }
        [Route("update")]
        [HttpPost]
        public IActionResult UpdateEmployee(ModelCL model)
        {
            return Ok(this.employeeBL.UpdateEmployee(model));
        }
        [Route("delete")]
        [HttpDelete]
        public IActionResult DeleteEmployee(int Id)
        {
            return Ok(this.employeeBL.DeleteEmployee(Id));
        }
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            return Ok(this.employeeBL.GetAllEmployee());
        }
    }
}