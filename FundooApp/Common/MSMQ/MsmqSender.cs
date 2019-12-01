//-----------------------------------------------------------------------
// <copyright file="MsmqSender.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// ----------------------------------------------------------------------
namespace FundooRepository.MSMQ
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Experimental.System.Messaging;

    /// <summary>
    /// this is class MsmqSender
    /// </summary>
    public class MsmqSender
    {
        /// <summary>
        /// Sends to MSMQ.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="email">The email.</param>
        public void SendToMsmq(string token,string email)
        {
            MessageQueue msmq = new MessageQueue();
            msmq.Path = @".\private$\ForgotPassword";
            if (!MessageQueue.Exists(msmq.Path))
            {
                MessageQueue.Create(msmq.Path);
            }
            Message message = new Message();
            //message.Formatter = new XmlMessageFormatter();
            message.Body = token;
            msmq.Send(message,email);
        }
    }
}
