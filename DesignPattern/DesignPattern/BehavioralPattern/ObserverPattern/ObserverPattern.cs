﻿//-----------------------------------------------------------------------
// <copyright file="ObserverPattern.cs" company="Bridgelabz">
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
    /// this is class ObserverPattern
    /// </summary>
    public class ObserverPattern
    {
        /// <summary>
        /// Patterns this instance.
        /// </summary>
        public void Pattern()
        {
            // The client code.
            var subject = new Subject();
            var observerA = new ConcreateObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreateObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
