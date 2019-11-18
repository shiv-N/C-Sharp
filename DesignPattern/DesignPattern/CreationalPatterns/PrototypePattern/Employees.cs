//-----------------------------------------------------------------------
// <copyright file="Employees.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------

namespace DesignPattern.PrototypePattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this is class Employees
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Employees"/> class.
        /// </summary>
        public Employees()
        {
            this.EmpList = new List<string>();
        }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the list of employee
        /// </summary>
        /// <value>
        /// The Employee list.
        /// </value>
        public List<string> EmpList { get; set; }

        /// <summary>
        /// Gets or sets the company phone no.
        /// </summary>
        /// <value>
        /// The company phone no.
        /// </value>
        public string CompanyPhoneNo { get; set; }

        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Shallows the copy.
        /// </summary>
        /// <returns> employee clone object</returns>
        public Employees ShallowCopy()
        {
            return (Employees)this.MemberwiseClone();
        }

        /// <summary>
        /// Deeps the copy.
        /// </summary>
        /// <returns>clone object</returns>
        public Employees DeepCopy()
        {
            Employees clone = (Employees)this.MemberwiseClone();
            clone.CompanyName = string.Copy(this.CompanyName);
            clone.CompanyPhoneNo = string.Copy(this.CompanyPhoneNo);
            return clone;
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        public void LoadData()
        {
            this.EmpList.Add("Ajay");
            this.EmpList.Add("Deepak");
            this.EmpList.Add("Kapil");
            this.EmpList.Add("Priyanka");
            this.EmpList.Add("Vaishu");
            this.EmpList.Add("neha");
            this.EmpList.Add("Shweta");
            this.EmpList.Add("Harsha");
            this.EmpList.Add("adimanv");
        }

        /// <summary>
        /// Displays the object.
        /// </summary>
        /// <param name="employees">The employees.</param>
        public void DisplayObj(Employees employees)
        {
            Console.WriteLine("CompanyName = " + employees.CompanyName + "\tCompanyPhoneNo = " + employees.CompanyPhoneNo + "\tPhone Number : " + employees.CompanyPhoneNo);
            Console.Write("Employees : ");
            foreach (string i in employees.EmpList)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine();
        }
    }
}
