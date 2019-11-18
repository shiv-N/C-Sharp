//-----------------------------------------------------------------------
// <copyright file="ConcreateObserverB.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace DesignPattern.BehavioralPattern.Observer_Pattern
{
    using System;

    /// <summary>
    /// this is ConcreateObserverB
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralPattern.Observer_Pattern.IObserver" />
    public class ConcreateObserverB : IObserver
    {
        /// <summary>
        /// method to update the observer,used by subject
        /// </summary>
        /// <param name="subject"></param>
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }
        }
    }
}
