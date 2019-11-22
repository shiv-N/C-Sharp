using System;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using CommonLibrary;
using RepositoryLibrary.Interface;
using System.Collections.Generic;

namespace RepositoryLibrary
{
    public class EmployeeRL : IEmployeeRL
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");

        public string DeleteEmployee(int Id)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("spDeleteEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("Id", Id);
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

        public IEnumerable<ModelCL> GetAllEmployee()
        {
            IList<ModelCL> employees = new List<ModelCL>();
            using (connection)
            {
                SqlCommand command = new SqlCommand("spGetEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ModelCL model = new ModelCL();
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

        public string Register(ModelCL model)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("spInsertEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("FirstName", model.FirstName);
                command.Parameters.AddWithValue("LastName", model.LastName);
                command.Parameters.AddWithValue("Age", model.Age);
                command.Parameters.AddWithValue("Email", model.Email);
                command.Parameters.AddWithValue("EmployeeAddress", model.EmployeeAddress);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result != 0)
                {
                    return model.FirstName+"'s record Registered SuccessFully";
                }
                else
                {
                    return "Data is not Registered";
                }
            }
        }

        public string UpdateEmployee(ModelCL model)
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
