using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Interface
{
   public interface IEmployeeBL
    {
        string Register(ModelCL model);
        public IEnumerable<ModelCL> GetAllEmployee();
        //void GetEmployee();
        public string DeleteEmployee(int Id);
        public string UpdateEmployee(ModelCL model);
    }
}
