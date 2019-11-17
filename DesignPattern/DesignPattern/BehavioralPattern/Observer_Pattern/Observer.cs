using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehavioralPattern.Observer_Pattern
{
    public interface IObserver
    {       
        /// <summary>
        /// method to update the observer,used by subject
        /// </summary>
        void Update(ISubject subject);
    }
}
