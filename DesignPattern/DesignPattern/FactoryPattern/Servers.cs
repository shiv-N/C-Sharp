using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    class Servers : IComputers
    {
        private string name;
        public string Model_Name(string name)
        {
            this.name = name;
            return this.name;
        }
    }
}
