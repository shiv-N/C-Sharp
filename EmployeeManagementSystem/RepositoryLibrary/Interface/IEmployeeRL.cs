using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLibrary.Interface
{
    public interface IEmployeeRL
    {
        string Register(ModelCL model);
        IEnumerable<ModelCL> GetAllEmployee();
        public string DeleteEmployee(int Id);

        public string UpdateEmployee(ModelCL model);
    }
}
