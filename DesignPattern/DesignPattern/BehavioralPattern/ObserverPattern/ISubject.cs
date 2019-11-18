//-----------------------------------------------------------------------
// <copyright file="ISubject.cs" company="Bridgelabz">
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
    /// <summary>
    /// this is interface ISubject
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attaches an observer to the subject
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Attach(IObserver observer);
        /// <summary>
        /// Detaches an observer from the subject.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Detach(IObserver observer);
        /// <summary>
        /// Notifies all observer about event.
        /// </summary>
        void Notify();
    }
}
