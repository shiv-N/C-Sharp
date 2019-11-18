//-----------------------------------------------------------------------
// <copyright file="SocketObjectImpl.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Adapter_Design_Pattern
{
    /// <summary>
    /// this is class SocketObject Implementation
    /// </summary>
    /// <seealso cref="DesignPattern.Adapter_Design_Pattern.ISocketAdapter" />
    public class SocketObjectImpl : ISocketAdapter
    {
        Socket socket = new Socket();

        /// <summary>
        /// Get120s the volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get120Volts()
        {
            return socket.SocketVolt();
        }

        /// <summary>
        /// Get12s the volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get12Volts()
        {
            Volts v = socket.SocketVolt();
            return ConvertVolt(v, 10);
        }

        /// <summary>
        /// Get3s the volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get3Volts()
        {
            Volts v = socket.SocketVolt();
            return ConvertVolt(v, 40);
        }

        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        private Volts ConvertVolt(Volts v, int i)
        {
            return new Volts(v.Getvolts() / i);
        }
    }
}
