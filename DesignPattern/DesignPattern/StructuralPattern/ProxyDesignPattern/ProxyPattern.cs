//-----------------------------------------------------------------------
// <copyright file="ProxyPattern.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern
{
    using DesignPattern.StructuralPattern.Proxy_Design_Pattern;
    using System;

    /// <summary>
    /// this is ProxyPattern
    /// </summary>
    class ProxyPattern
    {
        /// <summary>
        /// Patterns this instance.
        /// </summary>
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
