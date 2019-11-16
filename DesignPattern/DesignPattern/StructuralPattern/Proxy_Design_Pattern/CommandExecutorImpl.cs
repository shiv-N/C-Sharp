using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.Proxy_Design_Pattern
{
    public class CommandExecutorImpl : ICommandExecutor
    {
        public void RunCommmand(string cmd)
        {
            Console.WriteLine(cmd+"\nCommand Executed");
        }
    }
}
