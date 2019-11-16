using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    class Prototype_Pattern
    {
        public void Pattern()
        {
            Employees employees = new Employees
            {
                CompanyName = "Bridgelabz",
                CompanyPhoneNo = "9080706050"
            };
            employees.LoadData();
            employees.DateTime = Convert.ToDateTime("16-11-2019");

            Employees employeeCopyOne = employees.ShallowCopy();
            Employees employeeCopyTwo = employees.DeepCopy();
            Console.WriteLine("Details of Employees list:");
            employees.DisplayObj(employees);
            Console.WriteLine("\nDetails of Employee Shallow Copy list:");
            employees.DisplayObj(employeeCopyOne);
            Console.WriteLine("\nDetails of Employee Deep Copy list:");
            employees.DisplayObj(employeeCopyTwo);
        }
       
    }
}
