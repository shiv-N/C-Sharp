using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CashCounter
    {
        public void Queue()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your balance:");
            int balance = Convert.ToInt32(Console.ReadLine());
            QueueUtility queue = new QueueUtility();
            queue.EnQueue(name, balance);
            Console.ReadKey();
        }
    }
}
