using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    sealed class Singleton_Structure
    {
        private static Singleton_Structure instance;
        private static int count = 0;
        private Singleton_Structure()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        public static Singleton_Structure GetInstance()
        {
            
            if (instance == null)
            {
                instance = new Singleton_Structure();
            }
            return instance;

        }
        public void Instance(string input)
        {
            Console.WriteLine(input);
        }
    }
}
