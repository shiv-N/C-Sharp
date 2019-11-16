using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Thread_Safety
    {
        private static readonly object obj = new object();
        private static Thread_Safety instance;
        private static int count = 0;
        private Thread_Safety()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        public static Thread_Safety GetInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if(instance == null)
                    {
                        instance = new Thread_Safety();
                    }
                }
            }
            return instance;

        }
        public void Instance(string input)
        {
            Console.WriteLine(input);
        }
    }
}
