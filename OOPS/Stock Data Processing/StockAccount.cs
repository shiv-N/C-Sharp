using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Data_Processing
{
    class StockAccount
    {
        public List<Records> Company_Records { get; set; }

        public class Records
        {
             public string Symbol{ get; set; }
             public int StockVolume { get; set; }
            public string DateTime { get; set; }
            public int StockValue { get; set; }
             public int StockPrice { get; set; }
        }
    }
}
