//-----------------------------------------------------------------------
// <copyright file="AccountRepository.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace FundooRepository
{
    using Common;
    using Common.Models;
    using FundooRepository.Interface;
    using FundooRepository.MSMQ;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// this is class AccountRepository
    /// </summary>
    /// <seealso cref="FundooRepository.Interface.IAccountRepository" />
    public class AccountRepository : IAccountRepository
    {
        /// <summary>
        /// The connection
        /// </summary>
        SqlConnection connection = new SqlConnection(@"Data Source=(localDB)\localhost;Initial Catalog=EmployeeDetails;Integrated Security=True");

        /// <summary>
        /// The MSMQ
        /// </summary>
        MsmqSender msmq;

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">Password</exception>
        public async Task<string> RegisterAsync(RegisterRequestModel model)
        {
            try
            {
                if (model.Password == null)
                {
                    throw new ArgumentNullException("Password");
                }
                else
                {
                    string encrypted = EncryptPassword(model.Password);
                    SqlCommand command = StoreProcedureConnection("spInsertUser");
                    command.Parameters.AddWithValue("FirstName", model.FirstName);
                    command.Parameters.AddWithValue("LastName", model.LastName);
                    command.Parameters.AddWithValue("PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("Email", model.Email);
                    command.Parameters.AddWithValue("Password", encrypted);
                    command.Parameters.AddWithValue("UserAddress", model.UserAddress);
                    connection.Open();
                    int result = await command.ExecuteNonQueryAsync();
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

        /// <summary>
        /// Logins the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string Login(LoginRequestModel model)
        {
            try
            {
                string encrypted = EncryptPassword(model.Password);
                SqlCommand command = StoreProcedureConnection("spLogin");
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@Password", encrypted);
                connection.Open();
                 SqlDataReader dataReader = command.ExecuteReader();
                string token = string.Empty;
                while (dataReader.Read())
                {
                    if ((dataReader["Email"].ToString()).Equals(model.Email))
                    {
                        token = GenrateJWTToken(model.Email);
                        break;
                    }
                }
                connection.Close();
                return token;
        }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IEnumerable<RegisterRequestModel> GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Forgots the password.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        public string ForgotPassword(ForgotPassword model)
        {

            string email = model.Email;
            SqlCommand command = StoreProcedureConnection("spForgotPassword");
            command.Parameters.AddWithValue("@Email", model.Email);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                string token = GenrateJWTToken(email);
                msmq = new MsmqSender();
                msmq.SendToMsmq(token, model.Email);
                return "ForgotPasswordConformation\n"+"token : "+token;
            }
            return string.Empty;
        }

        private SqlCommand StoreProcedureConnection(string Name)
        {
            SqlCommand command = new SqlCommand(Name, connection);
            command.CommandType = CommandType.StoredProcedure;
            return command;
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="resetModel">The reset model.</param>
        /// <returns></returns>
        public  string ResetPassword(ResetModel resetModel)
        {
            string email = DecodeToken(resetModel);
            string encrypted = EncryptPassword(resetModel.password);
            SqlCommand command = StoreProcedureConnection("spUpdatePasswordByEmail");
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", encrypted);
            connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            connection.Close();
            return "updated";
        }

        /// <summary>
        /// this is method encryptPassword
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        private static string EncryptPassword(string Password)
        {
            var provider = new SHA1CryptoServiceProvider();
            var encoding = new UnicodeEncoding();
            byte[] encrypt = provider.ComputeHash(encoding.GetBytes(Password));
            String encrypted = Convert.ToBase64String(encrypt);
            return encrypted;
        }

        /// <summary>
        /// this is method for DecodeToken
        /// </summary>
        /// <param name="resetModel"></param>
        /// <returns></returns>
        private static string DecodeToken(ResetModel resetModel)
        {
            var stream = resetModel.token;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = handler.ReadToken(stream) as JwtSecurityToken;
            var email = tokenS.Claims.FirstOrDefault(claim => claim.Type == "email").Value;
            return email;
        }

        /// <summary>
        /// this is a method for GenrateJWTToken.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private static string GenrateJWTToken(string email)
        {
            var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
            var signinCredentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
                        {
                            new Claim("email", email),
                            new Claim(ClaimTypes.Role, "User")
                        };
            var tokenOptionOne = new JwtSecurityToken(
                issuer: "http://localhost:5000",
                audience: "http://localhost:5000",
                claims: claims,
                expires: DateTime.Now.AddMinutes(10),
                signingCredentials: signinCredentials
                );
            string token = new JwtSecurityTokenHandler().WriteToken(tokenOptionOne);
            return token;
        }
    }
}
