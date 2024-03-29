﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Mediator_Pattern
{
   public class ConcreteColleagueB : Colleague
{
 public ConcreteColleagueB(IMediator mediator) : base(mediator) { }

 public void Send(string msg)
 {
 Console.WriteLine("B send message:" + msg);
 _mediator.SendMessage(this, msg);
 }

 public void Receive(string msg)
 {
 Console.WriteLine("B receive message:" + msg);
 }
}
}
