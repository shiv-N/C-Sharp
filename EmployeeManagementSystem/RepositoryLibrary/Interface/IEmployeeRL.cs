using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLibrary.Interface
{
    interface IEmployeeRL
    {
        void Register(ModelCL model);
        void GetEmployee();
        void InsertEmployee();
        void updateEmployee();
    }
}
