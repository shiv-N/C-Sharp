//-----------------------------------------------------------------------
// <copyright file="Service1.svs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------

namespace WcfEmployeeDemo
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    //// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    //// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.    
    
    /// <summary>
    /// This is Service1 class contains implementation
    /// </summary>
    /// <seealso cref="WcfEmployeeDemo.IService1" />
    public class Service1 : IService1
    {
        /// <summary>
        /// The connection
        /// </summary>
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>string value</returns>
        public string DeleteEmployee(Employee id)
        {
            using (this.connection)
            {
                SqlCommand command = new SqlCommand("spDeleteEmployee", this.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", id.Id);
                this.connection.Open();
                int result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return id + " id Deleted from Database";
                }
                else
                {
                    return "Record is unable to deleted";
                }
            }
        }

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>IEnumerable value </returns>
        public IEnumerable<Employee> GetAllEmployee()
        {
            IList<Employee> employees = new List<Employee>();
            using (this.connection)
            {
                SqlCommand command = new SqlCommand("spGetEmployee", this.connection);
                command.CommandType = CommandType.StoredProcedure;

                this.connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Employee model = new Employee();
                    model.Id = (int)dataReader["Id"];
                    model.FirstName = dataReader["Firstname"].ToString();
                    model.LastName = dataReader["Lastname"].ToString();
                    model.Age = dataReader["Age"].ToString();
                    model.Email = dataReader["Email"].ToString();
                    model.EmployeeAddress = dataReader["EmployeeAddress"].ToString();
                    employees.Add(model);
                }

                this.connection.Close();
            }

            return employees;
        }

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>string value </returns>
        public string Register(Employee model)
        {
            using (this.connection)
            {
                SqlCommand command = new SqlCommand("spInsertEmployee", this.connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", model.FirstName);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@Age", model.Age);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@EmployeeAddress", model.EmployeeAddress);
                this.connection.Open();
                int result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return model.FirstName + "'s record Registered SuccessFully";
                }
                else
                {
                    return "Data is not Registered";
                }
            }
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>string value</returns>
        public string UpdateEmployee(Employee model)
        {
            using (this.connection)
            {
                SqlCommand command = new SqlCommand("spUpdateEmployeeById", this.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", model.Id);
                command.Parameters.AddWithValue("FirstName", model.FirstName);
                command.Parameters.AddWithValue("LastName", model.LastName);
                command.Parameters.AddWithValue("Age", model.Age);
                command.Parameters.AddWithValue("Email", model.Email);
                command.Parameters.AddWithValue("EmployeeAddress", model.EmployeeAddress);
                this.connection.Open();
                int result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return model.Id + " Id Updated SuccessFully";
                }
                else
                {
                    return "Data is not Updated";
                }
            }
        }
    }
}
