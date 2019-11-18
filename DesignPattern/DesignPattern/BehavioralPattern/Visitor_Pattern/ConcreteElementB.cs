using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Visitor_Pattern
{
    public class ConcreteElementB : Element
    {
        /// <summary>
        /// AcceptVisitor as function
        /// </summary>
        /// <param name="visitor">visitor as object</param>
        public override void AcceptVisitor(Visitor visitor)
        {
            try
            {
                visitor.ConcreteElementB(this);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
