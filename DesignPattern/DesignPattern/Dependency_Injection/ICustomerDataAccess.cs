using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dependency_Injection
{
    public interface ICustomerDataAccess
    {
        string GetCustomerData(int id);
    }
}
