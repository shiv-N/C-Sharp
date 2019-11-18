//-----------------------------------------------------------------------
// <copyright file="ConcreateObserverA.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.Observer_Pattern
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.    
    /// <summary>
    /// this is class ConcreateObserverA
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralPattern.Observer_Pattern.IObserver" />
    public class ConcreateObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
