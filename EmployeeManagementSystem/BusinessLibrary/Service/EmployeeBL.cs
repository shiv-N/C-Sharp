using BusinessLibrary.Interface;
using CommonLibrary;
using RepositoryLibrary;
using RepositoryLibrary.Interface;
using System;
using System.Collections.Generic;

namespace BusinessLibrary
{
    public class EmployeeBL : IEmployeeBL
    {
        IEmployeeRL employeeRL;
        public EmployeeBL(IEmployeeRL employeeRL)
        {
            this.employeeRL = employeeRL;
        }

        public string DeleteEmployee(int Id)
        {
            if (Id != 0)
            {
                return this.employeeRL.DeleteEmployee(Id);
            }
            else
            {
                return "entry 0 is not valid";
            }
        }

        public IEnumerable<ModelCL> GetAllEmployee()
        {
            return employeeRL.GetAllEmployee();
        }

        public string Register(ModelCL model)
        {
            if(model != null)
            {
                return employeeRL.Register(model);
            }
            else
            {
                return "Record is empty";
            }
        }

        public string UpdateEmployee(ModelCL model)
        {
            if (model != null)
            {
                return employeeRL.UpdateEmployee(model);
            }
            else
            {
                return "Record is empty";
            }
        }
    }
}
