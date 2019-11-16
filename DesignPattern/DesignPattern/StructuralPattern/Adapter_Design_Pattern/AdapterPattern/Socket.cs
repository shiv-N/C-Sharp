using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Design_Pattern
{

    public class Socket
    {
        public Volts SocketVolt()
        {
            return new Volts(120);
        }
    }
}
