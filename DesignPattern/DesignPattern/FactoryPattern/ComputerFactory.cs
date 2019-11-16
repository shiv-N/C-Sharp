using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    class ComputerFactory
    {
        public static void Computer_Factory(string type)
        {
            if (type.Equals("PC"))
            {
                PC pc = new PC();
                Console.WriteLine("PC name is " + pc.Model_Name("DELL"));
            }
            else if (type.Equals("Servers"))
            {
                Servers servers = new Servers();
                Console.WriteLine("Server name is " + servers.Model_Name("Oracle"));
            }
        }
    }
}
