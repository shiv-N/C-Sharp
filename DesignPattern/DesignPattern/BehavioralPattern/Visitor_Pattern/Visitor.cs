using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Visitor_Pattern
{
    public abstract class Visitor
    {
        /// <summary>
        /// ConcreteElementA as function
        /// </summary>
        /// <param name="concreteElementA">concreteElementA as object</param>
        public abstract void ConcreteElementA(ConcreteElementA concreteElementA);

        /// <summary>
        /// ConcreteElementB as function
        /// </summary>
        /// <param name="concreteElementBClass">concreteElementB as object</param>
        public abstract void ConcreteElementB(ConcreteElementB concreteElementB);
    }
}
