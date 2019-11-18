using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Mediator_Pattern
{
    public class ConcreteMediator : IMediator
    {
        public ConcreteColleagueA Colleague1 { get; set; }

      //  public ConcreteColleagueB Colleague2 { get; set; }

        public void SendMessage(Colleague caller, string msg)
        {
            if (caller == Colleague1)
                Colleague2.Receive(msg);
            else
                Colleague1.Receive(msg);
        }
    }
}
