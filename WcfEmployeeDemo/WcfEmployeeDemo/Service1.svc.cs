using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfEmployeeDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");

        public string DeleteEmployee(Employee Id)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", Id.Id);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return Id + " id Deleted from Database";
                }
                else
                {
                    return "Record is unable to deleted";
                }
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            IList<Employee> employees = new List<Employee>();
            using (connection)
            {
                SqlCommand command = new SqlCommand("spGetEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
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
                connection.Close();
            }
            return employees;
        }

        public string Register(Employee model)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("spInsertEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@FirstName", model.FirstName);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@Age", model.Age);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@EmployeeAddress", model.EmployeeAddress);
                connection.Open();
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

        public string UpdateEmployee(Employee model)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("spUpdateEmployeeById", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", model.Id);
                command.Parameters.AddWithValue("FirstName", model.FirstName);
                command.Parameters.AddWithValue("LastName", model.LastName);
                command.Parameters.AddWithValue("Age", model.Age);
                command.Parameters.AddWithValue("Email", model.Email);
                command.Parameters.AddWithValue("EmployeeAddress", model.EmployeeAddress);
                connection.Open();
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
