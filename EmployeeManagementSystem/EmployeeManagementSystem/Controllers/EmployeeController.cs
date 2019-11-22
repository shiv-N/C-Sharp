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
        public string Register(ModelCL model)
        {
            var result = this.employeeBL.Register(model);
            return result;
        }
        [Route("update")]
        [HttpPost]
        public string UpdateEmployee(ModelCL model)
        {
            var result = this.employeeBL.UpdateEmployee(model);
            return result;
        }
        [Route("delete")]
        [HttpDelete]
        public string DeleteEmployee(int Id)
        {
            var result = this.employeeBL.DeleteEmployee(Id);
            return result;
        }
        [HttpGet]
        public IEnumerable<ModelCL> GetAllEmployee()
        {
            return this.employeeBL.GetAllEmployee();
        }
    }
}