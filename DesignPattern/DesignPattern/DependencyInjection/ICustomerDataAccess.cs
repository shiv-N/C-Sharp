//-----------------------------------------------------------------------
// <copyright file="ICustomerDataAccess.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Dependency_Injection
{
    /// <summary>
    /// this is ICustomerDataAccess
    /// </summary>
    public interface ICustomerDataAccess
    {
        string GetCustomerData(int id);
    }
}
