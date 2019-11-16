using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    sealed class Eager_Initialize
    {
        private static readonly Eager_Initialize instance = new Eager_Initialize();
        private static int count = 0;
        private Eager_Initialize()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        public static Eager_Initialize GetInstance()
        {
            return instance;
        }
        public void Instance(string input)
        {
            Console.WriteLine(input);
        }
    }
}
