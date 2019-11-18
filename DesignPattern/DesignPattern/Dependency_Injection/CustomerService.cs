using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dependency_Injection
{
    public class CustomerService
    {
        CustomerBusinessLogic BusinessLogic;
        public CustomerService()
        {
            BusinessLogic = new CustomerBusinessLogic(new CustomerDataAccess()); 
        }
        public string GetCustomerName(int id)
        {
            return BusinessLogic.ProcessCustomerData(id);
        }
    }
}
