//-----------------------------------------------------------------------
// <copyright file="Prototype_Pattern.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.PrototypePattern
{
    using System;

    /// <summary>
    /// this is Prototype Pattern class
    /// </summary>
    public class Prototype_Pattern
    {
        /// <summary>
        /// Patterns this instance.
        /// </summary>
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
