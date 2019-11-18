using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Mediator_Pattern
{
    public interface IMediator
    {
        void SendMessage(Colleague caller, string msg);
    }
}
