using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Interface
{
    interface IEmployeeBL
    {
        void Register(ModelCL model);
        void GetEmployee();
        void InsertEmployee();
        void updateEmployee();
    }
}
