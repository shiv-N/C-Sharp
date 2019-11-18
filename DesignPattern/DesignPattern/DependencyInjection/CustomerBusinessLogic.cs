//-----------------------------------------------------------------------
// <copyright file="CustomerBusinessLogic.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace DesignPattern.Dependency_Injection
{
    /// <summary>
    /// this is CustomerBusinessLogic class
    /// </summary>
    public class CustomerBusinessLogic
    {
        /// <summary>
        /// The data access
        /// </summary>
        ICustomerDataAccess dataAccess;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerBusinessLogic"/> class.
        /// </summary>
        /// <param name="customerDataAccess">The customer data access.</param>
        public CustomerBusinessLogic(ICustomerDataAccess customerDataAccess)
        {
            dataAccess = customerDataAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerBusinessLogic"/> class.
        /// </summary>
        public CustomerBusinessLogic()
        {
            dataAccess = new CustomerDataAccess();
        }

        /// <summary>
        /// Processes the customer data.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public string ProcessCustomerData(int id)
        {
            return dataAccess.GetCustomerData(id);
        }
    }
}
