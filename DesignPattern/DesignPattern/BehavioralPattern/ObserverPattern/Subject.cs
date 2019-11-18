//-----------------------------------------------------------------------
// <copyright file="Subject.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
using System;
using DesignPattern.BehavioralPattern.Observer_Pattern;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DesignPattern.BehavioralPattern.Observer_Pattern
{
    // subject owns some important state and notifies observers when
    // the state changes    
    /// <summary>
    /// this is class Subject
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralPattern.Observer_Pattern.ISubject" />
    public class Subject : ISubject
    {
        // for the sake of simplicity, the subject's state, essential to all
        // subscribers, is stored in this variable.
        public int State { get; set; } = -0;

        // list of subscribers. in  real life,the list of subscriber can be 
        // stored more comprehensively

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            Console.WriteLine("sub: attached on observer.");
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
            Console.WriteLine("sub: Detach an observer");
        }
        /// <summary>
        /// Notifies an update in each subscriber.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Notify()
        {
            Console.WriteLine("sub: notifying observer...");

            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
        // Usually, the subscription logic is only a fraction of what a Subject
        // can really do. Subjects commonly hold some important business logic,
        // that triggers a notification method whenever something important is
        // about to happen (or after it).
        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            this.Notify();
        }
    }
}
