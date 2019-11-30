using System;
using System.Collections.Generic;
using System.Text;
using Experimental.System.Messaging;

namespace FundooRepository.MSMQ
{
    public class MsmqSender
    {
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
