using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Stock
    {
        public void Stock_Management()
        {
            StockManage manage = JsonConvert.DeserializeObject<StockManage>(File.ReadAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\StockReport.json"));

            string stockRecord = string.Empty;
            foreach(StockManage.StockRecords stock in manage.Stocks)
            {
                stockRecord += "\nSymbol: " + stock.Symbol + "\nTotal stocks of Company: " + stock.Volume +
                     "\nStock Price: " + stock.Price+"\n";
            }
            Console.WriteLine(stockRecord);
        }
    }
}
