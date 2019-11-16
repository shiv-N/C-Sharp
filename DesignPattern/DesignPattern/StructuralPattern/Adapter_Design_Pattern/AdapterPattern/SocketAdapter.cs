using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Design_Pattern
{
    interface ISocketAdapter
    {
        Volts Get120Volts();
        Volts Get12Volts();
        Volts Get3Volts();
    }
}
