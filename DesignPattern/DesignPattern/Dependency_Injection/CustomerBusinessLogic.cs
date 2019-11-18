using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dependency_Injection
{
    public class CustomerBusinessLogic
    {
        ICustomerDataAccess dataAccess;
        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            dataAccess = customerDataAccess;
        }
        public CustomerBusinessLogic()
        {
            dataAccess = new CustomerDataAccess();
        }
        public string ProcessCustomerData(int id)
        {
            return dataAccess.GetCustomerData(id);
        }
    }
}
