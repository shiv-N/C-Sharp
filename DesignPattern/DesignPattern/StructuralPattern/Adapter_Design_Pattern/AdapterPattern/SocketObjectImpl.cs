using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Design_Pattern
{
    public class SocketObjectImpl : ISocketAdapter
    {
        Socket socket = new Socket();
        public Volts Get120Volts()
        {
            return socket.SocketVolt();
        }

        public Volts Get12Volts()
        {
            Volts v = socket.SocketVolt();
            return ConvertVolt(v, 10);
        }

        public Volts Get3Volts()
        {
            Volts v = socket.SocketVolt();
            return ConvertVolt(v, 40);
        }

        private Volts ConvertVolt(Volts v, int i)
        {
            return new Volts(v.Getvolts() / i);
        }
    }
}
