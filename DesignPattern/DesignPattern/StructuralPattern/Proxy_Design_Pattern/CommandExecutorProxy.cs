using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralPattern.Proxy_Design_Pattern
{
    class CommandExecutorProxy : ICommandExecutor
    {
        private bool IsAdmin;
        private ICommandExecutor executor;

        public CommandExecutorProxy(string user,string pwd)
        {
            if ("shiv".Equals(user) && "qwerty@789".Equals(pwd))
            {
                IsAdmin = true;
                executor = new CommandExecutorImpl();
            }
        }
        public void RunCommmand(string cmd)
        {
            if (IsAdmin)
            {
                executor.RunCommmand(cmd);
            }
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not allowed for non-admin users.");
                }
                else
                {
                    executor.RunCommmand(cmd);
                }
            }
        }
    }
}
