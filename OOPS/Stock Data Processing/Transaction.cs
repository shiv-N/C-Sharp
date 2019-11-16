using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Data_Processing
{
    class Transaction
    {
        public List<TransactionList> Transaction_List { get; set; }

        public class TransactionList
        {
            public string Customer_Id { get; set; }
            public string Symbol{ get; set; }
            public string UserName{ get; set; }
            public int Buys{ get; set; }
            public int Sell{ get; set; }
            public int ShareValue { get; set; }
        }
    }
}
