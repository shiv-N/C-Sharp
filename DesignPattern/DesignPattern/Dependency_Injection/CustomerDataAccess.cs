using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dependency_Injection
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess() { }

        public string GetCustomerData(int id)
        {
            return "Dummy custommer name";
        }
    }
}
