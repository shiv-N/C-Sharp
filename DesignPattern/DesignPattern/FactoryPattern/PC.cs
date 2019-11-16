using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    class PC : IComputers
    {
        private string name;
        public string Model_Name(string name)
        {
            return this.name = name;
        }
    }
}
