//-----------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Adapter_Design_Pattern
{
    /// <summary>
    /// this is interface ISocketAdapter
    /// </summary>
    interface ISocketAdapter
    {
        Volts Get120Volts();
        Volts Get12Volts();
        Volts Get3Volts();
    }
}
