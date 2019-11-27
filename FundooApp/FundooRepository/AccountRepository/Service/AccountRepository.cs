using Common;
using FundooRepository.Interface;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FundooRepository
{
    public class AccountRepository : IAccountRepository
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");

        public string Register(FundooModels model)
        {
            using (connection)
            {
                SqlCommand command = new SqlCommand("spInsertUser", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("FirstName", model.FirstName);
                command.Parameters.AddWithValue("LastName", model.LastName);
                command.Parameters.AddWithValue("PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("Email", model.Email);
                command.Parameters.AddWithValue("UserAddress", model.UserAddress);
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
    }
}
