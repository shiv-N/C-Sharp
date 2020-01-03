﻿//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace MSMQ
{
    using System;
    using Experimental.System.Messaging;
    using System.Net;
    using System.Net.Mail;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;

    /// <summary>
    /// this is class program
    /// </summary>
    class Program
    {
        /// <summary>
        /// this is entry point of program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MessageQueue msmq = new MessageQueue();
            string baseUrl = "http://localhost:3000/reset/";
            msmq.Path = @".\private$\ForgotPassword";
            Message message = new Message();
            message = msmq.Receive(new TimeSpan(0,0,5));
            message.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
            string msmqMessage = message.Body.ToString();
            Console.WriteLine(msmqMessage);

            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("saurabhnavdkar112@gmail.com", "saurabh@123");
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add("saurabhnavdkar112@gmail.com");
            mailMessage.From = new MailAddress("saurabhnavdkar112@gmail.com");
            mailMessage.Subject = "Forgot Password conformation";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = "<h4><a href="+baseUrl+ msmqMessage+"/>click here</a><br></br>to reset password</h4>";
            client.Send(mailMessage);

            var stream = msmqMessage;
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(stream);
            var tokenS = handler.ReadToken(stream) as JwtSecurityToken;
            string Email = tokenS.Claims.FirstOrDefault(claim => claim.Type == "email").Value;
            //int Id = tokenS.Claims.FirstOrDefault(claim => claim.Type == "id").Value;
            Console.WriteLine("message sent to "+Email);
            Console.ReadKey();
        }
    }
}
