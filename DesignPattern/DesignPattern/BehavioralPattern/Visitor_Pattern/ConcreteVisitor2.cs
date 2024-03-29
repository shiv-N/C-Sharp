﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Visitor_Pattern
{
    public class ConcreteVisitor2 : Visitor
    {
        /// <summary>
        /// ConcreteElementA as function
        /// </summary>
        /// <param name="concreteElementA">concreteElementA as object</param>
        public override void ConcreteElementA(ConcreteElementA concreteElementA)
        {
            try
            {
                Console.WriteLine("{0} visited by {1}", concreteElementA.GetType().Name, this.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ConcreteElementB as function
        /// </summary>
        /// <param name="concreteElementB">concreteElementB as object</param>
        public override void ConcreteElementB(ConcreteElementB concreteElementB)
        {
            try
            {
                Console.WriteLine("{0} visited by {1}", concreteElementB.GetType().Name, this.GetType().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
