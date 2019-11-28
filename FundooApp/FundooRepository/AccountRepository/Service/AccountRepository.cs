using Common;
using FundooRepository.Interface;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace FundooRepository
{
    public class AccountRepository : IAccountRepository
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");

        public string Register(FundooModels model)
        {
            try
            {
                if (model.Password == null)
                {
                    throw new ArgumentNullException("Password");
                }
                else
                {
                    var provider = new SHA1CryptoServiceProvider();
                    var encoding = new UnicodeEncoding();
                    byte[] encrypt = provider.ComputeHash(encoding.GetBytes(model.Password));
                    String encrypted = Convert.ToBase64String(encrypt);
                    SqlCommand command = new SqlCommand("spInsertUser", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("FirstName", model.FirstName);
                    command.Parameters.AddWithValue("LastName", model.LastName);
                    command.Parameters.AddWithValue("PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("Email", model.Email);
                    command.Parameters.AddWithValue("Password", encrypted);
                    command.Parameters.AddWithValue("UserAddress", model.UserAddress);
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        return "User is Registered SuccessFully";
                    }
                    else
                    {
                        return "Data is not Registered";
                    }
                }
            }
            catch(Exception e)
            {
                return "Data is not Registered. it throws exception as following.\n"+e.Message;
            }
        }

        public FundooModels Login(FundooModels model)
        {
            try
            {
                var provider = new SHA1CryptoServiceProvider();
                var encoding = new UnicodeEncoding();
                byte[] encrypt = provider.ComputeHash(encoding.GetBytes(model.Password));
                String encrypted = Convert.ToBase64String(encrypt);
                SqlCommand command = new SqlCommand("spLogin", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Password", encrypted);
                connection.Open();
                 SqlDataReader dataReader = command.ExecuteReader();
                FundooModels newModel = new FundooModels();
                while (dataReader.Read())
                {
                    if ((dataReader["Email"].ToString()).Equals(model.Email))
                    {
                        newModel.Id = (int)dataReader["Id"];
                        newModel.FirstName = dataReader["Firstname"].ToString();
                        newModel.LastName = dataReader["Lastname"].ToString();
                        newModel.Email = dataReader["Email"].ToString();
                        newModel.PhoneNumber = dataReader["PhoneNumber"].ToString();
                        newModel.UserAddress = dataReader["UserAddress"].ToString();
                        break;
                    }
                }
                connection.Close();
                return newModel;
        }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
