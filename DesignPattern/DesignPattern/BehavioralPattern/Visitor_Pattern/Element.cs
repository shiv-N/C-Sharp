using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Visitor_Pattern
{
   abstract public class Element
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitor">AcceptVisitor as object</param>
        public abstract void AcceptVisitor(Visitor visitor);
    }
}
