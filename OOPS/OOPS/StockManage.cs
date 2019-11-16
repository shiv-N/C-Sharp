using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class StockManage
    {
        public List<StockRecords> Stocks { get; set; }

        public class StockRecords
        {
            public string Symbol { get; set; }
            public int Volume { get; set; }
            public int Price { get; set; }
        }
    }
}
