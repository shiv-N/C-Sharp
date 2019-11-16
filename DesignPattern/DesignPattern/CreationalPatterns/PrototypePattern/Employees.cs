using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    class Employees
    {
        public string CompanyName;
        public List<string> EmpList { get; set; }
        public string CompanyPhoneNo;
        public DateTime DateTime;

        public Employees()
        {
            EmpList = new List<string>();
        }
        public Employees ShallowCopy()
        {
            return (Employees)this.MemberwiseClone();
        }

        public Employees DeepCopy()
        {
            Employees clone = (Employees)this.MemberwiseClone();
            clone.CompanyName = string.Copy(CompanyName);
            clone.CompanyPhoneNo = string.Copy(CompanyPhoneNo);
            return clone;
        }
        public void LoadData()
        {
            EmpList.Add("Ajay");
            EmpList.Add("Deepak");
            EmpList.Add("Kapil");
            EmpList.Add("Priyanka");
            EmpList.Add("Vaishu");
            EmpList.Add("neha");
            EmpList.Add("Shweta");
            EmpList.Add("Harsha");
            EmpList.Add("adimanv");
        }
        public void DisplayObj(Employees employees)
        {
            Console.WriteLine("CompanyName = " + employees.CompanyName + "\tCompanyPhoneNo = " + employees.CompanyPhoneNo +
                "\tPhone Number : "+employees.CompanyPhoneNo);
            Console.Write("Employees : ");
            foreach (string i in employees.EmpList)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();
        }
    }
}
