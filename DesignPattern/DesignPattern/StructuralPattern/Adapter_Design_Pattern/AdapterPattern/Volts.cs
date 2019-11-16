using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Design_Pattern
{
    public class Volts
    {
        private int Volt { get; set; }
        public Volts(int volt)
        {
            this.Volt = volt;
        }
        public int Getvolts()
        {
            return this.Volt;
        }
    }
}
