using DesignPattern.StructuralPattern.Proxy_Design_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ProxyPattern
    {
        public void Pattern()
        {
            ICommandExecutor executor = new CommandExecutorProxy("shiv", "qwerty@789");
            try
            {
                executor.RunCommmand("ls -ltr");
                executor.RunCommmand(" rm -rf abc.pdf");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception Message: "+e.Message);
            }
        }
    }
}
