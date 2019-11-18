using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral_Pattern.Visitor_Pattern
{
    public class MainVisitor
    {
        /// <summary>
        /// VisitorFunction as function
        /// </summary>
        public static void VisitorFunction()
        {
            try
            {
                //// create Instance of an Structur class
                Structure structur = new Structure();
                structur.Attach(new ConcreteElementA());
                structur.Attach(new ConcreteElementB());

                //// create Instance of an ConcreteVisitor1 class
                ConcreteVisitor1 concreteVisitor1 = new ConcreteVisitor1();

                //// create Instance of an ConcreteVisitor2 class
                ConcreteVisitor2 concreteVisitor2 = new ConcreteVisitor2();

                structur.AcceptVisitor(concreteVisitor1);
                structur.AcceptVisitor(concreteVisitor2);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
