using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Data_Processing
{
    class CustomerRecords
    {
        public List<Records> Customer_Records{ get;set;}

        public class Records
        {
            public string Customer_Id { get; set; }
            public string UserName { get; set; }
            public Dictionary<string, int> StockDetails = new Dictionary<string, int>() { { "HDFCBANK", 0 }, { "RELIANCE", 0 }, { "TCS", 0 }, { "ICICIBANK", 0 }, { "INFOSYS", 0 }, { "TATA", 0 } };
            public int Total_Shares { get; set; }
            public int Balance { get; set; }
        }
    }
}
