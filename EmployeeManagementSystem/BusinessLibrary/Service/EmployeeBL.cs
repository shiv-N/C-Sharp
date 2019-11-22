using BusinessLibrary.Interface;
using CommonLibrary;
using System;

namespace BusinessLibrary
{
    public class EmployeeBL : IEmployeeBL
    {
        private ModelCL _register;

        public void GetEmployee()
        {
            throw new NotImplementedException();
        }

        public void InsertEmployee()
        {
            
        }

        public void Register(ModelCL model)
        {
            _register = model;
        }

        public void updateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
