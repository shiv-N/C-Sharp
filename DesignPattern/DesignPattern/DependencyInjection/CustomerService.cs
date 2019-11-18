//-----------------------------------------------------------------------
// <copyright file="CustomerService.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Dependency_Injection
{
    /// <summary>
    /// this is CustomerService
    /// </summary>
    public class CustomerService
    {
        /// <summary>
        /// The business logic
        /// </summary>
        CustomerBusinessLogic BusinessLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerService"/> class.
        /// </summary>
        public CustomerService()
        {
            BusinessLogic = new CustomerBusinessLogic(new CustomerDataAccess()); 
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string GetCustomerName(int id)
        {
            return BusinessLogic.ProcessCustomerData(id);
        }
    }
}
