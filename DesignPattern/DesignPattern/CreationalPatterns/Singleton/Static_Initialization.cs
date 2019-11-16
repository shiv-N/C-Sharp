using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Lazy_Initialization
    {
        private static readonly Lazy<Lazy_Initialization> instance = new Lazy<Lazy_Initialization>(()=> new Lazy_Initialization());
        private static int count = 0;
        private Lazy_Initialization()
        {
            count++;
            Console.WriteLine("Construtor call Count Number =  " + count.ToString());
        }

        public static Lazy_Initialization GetInstance()
        {
            return instance.Value;
        }
        public void Instance(string input)
        {
            Console.WriteLine(input);
        }
    }
}
