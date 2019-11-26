//-----------------------------------------------------------------------
// <copyright file="IService1.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace WcfEmployeeDemo
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    //// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.    
    
    /// <summary>
    /// This is service1 interface
    /// </summary>
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>string value</returns>
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/register")]
        string Register(Employee model);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>IEnumerable list </returns>
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/get")]
        IEnumerable<Employee> GetAllEmployee();

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string value</returns>
        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Delete")]
        string DeleteEmployee(Employee id);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>string value</returns>
        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Put")]
        string UpdateEmployee(Employee model);

        // TODO: Add your service operations here
    }

    //// Use a data contract as illustrated in the sample below to add composite types to service operations.    
    
    /// <summary>
    /// This is class Employee contains models
    /// </summary>
    [DataContract]
    public class Employee
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        /// <value>
        /// The Id.
        /// </value>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the firstName.
        /// </summary>
        /// <value>
        /// The firstName.
        /// </value>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Age.
        /// </summary>
        /// <value>
        /// The Age.
        /// </value>
        [DataMember]
        public string Age { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// The Email.
        /// </value>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the EmployeeAddress.
        /// </summary>
        /// <value>
        /// The EmployeeAddress.
        /// </value>
        [DataMember]
        public string EmployeeAddress { get; set; }
    }
}
