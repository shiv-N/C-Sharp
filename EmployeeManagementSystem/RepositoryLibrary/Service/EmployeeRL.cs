using System;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using CommonLibrary;
using RepositoryLibrary.Interface;

namespace RepositoryLibrary
{
    public class EmployeeRL : IEmployeeRL
    {
        private ModelCL _register;

        public void Connect()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            Console.WriteLine(dataReader);
            connection.Close();
        }

        public void GetEmployee()
        {
            throw new NotImplementedException();
        }

        public void InsertEmployee()
        {
            throw new NotImplementedException();
        }

        public void Register(ModelCL model)
        {
            _register = model;
        }

        public void updateEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
