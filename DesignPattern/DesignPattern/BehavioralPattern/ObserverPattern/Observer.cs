//-----------------------------------------------------------------------
// <copyright file="IObserver.cs" company="Bridgelabz">
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
    /// this is interface IObserver
    /// </summary>
    public interface IObserver
    {       
        /// <summary>
        /// method to update the observer,used by subject
        /// </summary>
        void Update(ISubject subject);
    }
}
