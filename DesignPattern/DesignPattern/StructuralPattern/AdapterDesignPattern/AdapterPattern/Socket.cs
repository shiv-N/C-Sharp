//-----------------------------------------------------------------------
// <copyright file="Socket.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Adapter_Design_Pattern
{
    /// <summary>
    /// this is class Socket
    /// </summary>
    public class Socket
    {
        public Volts SocketVolt()
        {
            return new Volts(120);
        }
    }
}
