//-----------------------------------------------------------------------
// <copyright file="CustomerDataAccess.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Dependency_Injection
{
    /// <summary>
    /// this is class CustomerDataAccess
    /// </summary>
    /// <seealso cref="DesignPattern.Dependency_Injection.ICustomerDataAccess" />
    public class CustomerDataAccess : ICustomerDataAccess
    {
        /// <summary>
        /// Gets the customer data.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string GetCustomerData(int id)
        {
            return "Dummy custommer name";
        }
    }
}
