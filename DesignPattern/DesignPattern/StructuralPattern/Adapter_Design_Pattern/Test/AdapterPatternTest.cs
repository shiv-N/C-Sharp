using DesignPattern.Adapter_Design_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Test
{
    class AdapterPatternTest
    {
        public void Adapter_Pattern()
        {
            TestSocketObject();
            Console.WriteLine("--------------------------------------------");
            TestSocketClass();
        }

        private static void TestSocketObject()
        {
            ISocketAdapter socketAdapter = new SocketObjectImpl();
            Volts v3 = socketAdapter.Get3Volts();
            Volts v12 = socketAdapter.Get12Volts();
            Volts v120 = socketAdapter.Get120Volts();
            Console.WriteLine("V3 using obj Adapter = " + v3.Getvolts());
            Console.WriteLine("V12 using obj Adapter = " + v12.Getvolts());
            Console.WriteLine("V120 using obj Adapter = " + v120.Getvolts());
        }
        private static void TestSocketClass()
        {
            ISocketAdapter socketAdapter = new SocketClassAdapterImpl();
            Volts v3 = socketAdapter.Get3Volts();
            Volts v12 = socketAdapter.Get12Volts();
            Volts v120 = socketAdapter.Get120Volts();
            Console.WriteLine("V3 using class Adapter = " + v3.Getvolts());
            Console.WriteLine("V12 using class Adapter = " + v12.Getvolts());
            Console.WriteLine("V120 using class Adapter = " + v120.Getvolts());
        }
    }
}
