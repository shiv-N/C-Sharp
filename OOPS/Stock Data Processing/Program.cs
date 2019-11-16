using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Data_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validation = false;
            CustomerRecords customer = JsonConvert.DeserializeObject<CustomerRecords>(File.ReadAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\CustomerRecords.json"));
            StockAccount stockAccount = JsonConvert.DeserializeObject<StockAccount>(File.ReadAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\StockAccount.json"));
            Transaction transaction = JsonConvert.DeserializeObject<Transaction>(File.ReadAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\Transaction.json"));
            while (!validation)
            {
                try
                {
                    foreach (CustomerRecords.Records record in customer.Customer_Records)
                    {
                        Console.WriteLine("Hello " + record.UserName + ", Wellcome to the Stock Market...");
                        StartValidation:
                        Console.WriteLine("1.Sell Stock\n2.Buy Stock\n3.Display all Transactions \n4.EXIT\n"+record.UserName+",Select option:");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                        case 1:
                            Console.WriteLine("Checking how many shares you have left " + record.UserName + "...");
                            if (record.Total_Shares <= 0)
                            {
                                Console.WriteLine(record.UserName + " you don't have Shares for sell.Sorry!!!!!!");
                                break;
                            }
                            else
                            {
                                bool valid = false;
                                int indexTwo = 0;
                                foreach (KeyValuePair<string, int> val in record.StockDetails)
                                {
                                    if (val.Value > 0)
                                    {
                                        indexTwo++;
                                        Console.WriteLine(indexTwo + ". " + val.Key + ": " + val.Value);
                                        valid = true;
                                    }
                                }
                                if (!valid)
                                {
                                    Console.WriteLine(record.UserName + " you don't have Shares for sell.Sorry!!!!!!");
                                    break;
                                }
                                Console.WriteLine("Enter a name of share you want to Sell(Input Case Sensitive):");
                                string shareName = Console.ReadLine();
                                bool flag = false;
                                foreach (KeyValuePair<string, int> val in record.StockDetails)
                                {
                                    if (val.Key.Equals(shareName) && val.Value > 0)
                                    {
                                        flag = true;
                                        break;
                                    }
                                }
                                if (flag)
                                {
                                    foreach (StockAccount.Records i in stockAccount.Company_Records)
                                    {
                                        if (i.Symbol.Equals(shareName))
                                        {
                                            Console.WriteLine("Stock Price: " + i.StockPrice);
                                            Console.WriteLine("How Many Shares You Want To Sell:");
                                            int stockNo = Convert.ToInt32(Console.ReadLine());
                                            if (stockNo > 0 && stockNo < record.StockDetails[shareName])
                                            {
                                                record.StockDetails[shareName] = record.StockDetails[shareName] - stockNo;
                                                i.StockVolume += stockNo;
                                                record.Total_Shares = record.StockDetails["HDFCBANK"] + record.StockDetails["RELIANCE"] + record.StockDetails["TCS"] + record.StockDetails["INFOSYS"] + record.StockDetails["ICICIBANK"] + record.StockDetails["TATA"];
                                                i.StockValue -= (stockNo * i.StockPrice);
                                                Transaction.TransactionList newObj = new Transaction.TransactionList();
                                                newObj.Customer_Id = record.Customer_Id;
                                                newObj.Symbol = i.Symbol;
                                                newObj.UserName = record.UserName;
                                                newObj.Sell = stockNo;
                                                newObj.Buys = 0;
                                                newObj.ShareValue = (stockNo * i.StockPrice);
                                                transaction.Transaction_List.Add(newObj);
                                                File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\CustomerRecords.json", JsonConvert.SerializeObject(customer));
                                                File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\StockAccount.json", JsonConvert.SerializeObject(stockAccount));
                                                File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\Transaction.json", JsonConvert.SerializeObject(transaction));
                                                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t*****Customer data******" + "\n\t\t\tCustomer Id: " + record.Customer_Id + "\t\t\tUserName: " + record.UserName + "\n\t\t\tTotal_Shares:" + record.Total_Shares + "\t\t\tBalance:" + record.Balance);
                                                    Console.Write("\t\t\tStock==>");
                                                foreach (KeyValuePair<string, int> val in record.StockDetails)
                                                {
                                                    if (val.Value > 0)
                                                    {
                                                        Console.Write(val.Key + ": " + val.Value+"\t");
                                                    }
                                                }
                                                    Console.WriteLine("\n\n");
                                                //Console.WriteLine("\n*****bank data****\nSymbol: " + i.Symbol + "\n volume " + i.StockVolume + "\nvalue: " + i.StockValue + "\nPrice:" + i.StockPrice);
                                            }
                                            else
                                            {
                                                Console.WriteLine("You don't have enough shares of " + i.Symbol + "\n Your Share Balance:" + record.StockDetails[shareName] +
                                                    "\n Enter input again.");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Input!!,Enter input again.\n");
                                        goto StartValidation;
                                }

                            }
                            break;
                        case 2:
                                stockvalid:
                                Console.WriteLine("Stock List As Following:");
                                int index = 0;
                                foreach (StockAccount.Records j in stockAccount.Company_Records)
                                {
                                    index++;
                                    Console.WriteLine(index + ". " + j.Symbol);
                                }
                                Console.WriteLine("Enter Option Name For Buying Stocks(Input Case Sensitive):");
                                string stockName = Console.ReadLine();
                                bool validStock = false;
                                foreach (StockAccount.Records i in stockAccount.Company_Records)
                                {
                                    if (i.Symbol.Equals(stockName))
                                    {
                                        validStock = true;
                                        Console.WriteLine("*******" + i.Symbol + "******" + "\nCurrent Stock Price: " + i.StockPrice);
                                        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t*****Customer data******" + "\n\t\t\tCustomer Id: " + record.Customer_Id + "\t\t\tUserName: " + record.UserName + "\n\t\t\tTotal_Shares:" + record.Total_Shares + "\t\t\tBalance:" + record.Balance);
                                        Console.Write("\t\t\tStock==>");
                                        foreach (KeyValuePair<string, int> val in record.StockDetails)
                                        {
                                            if (val.Value > 0)
                                            {
                                                Console.Write(val.Key + ": " + val.Value + "\t");
                                            }
                                        }
                                        Console.WriteLine("\n");
                                        BalanceValid:
                                        Console.WriteLine(record.UserName + ", how many shares you want to buy from " + i.Symbol + " :");
                                        int stockNo = Convert.ToInt32(Console.ReadLine());
                                        if (stockNo <= 0)
                                        {
                                            Console.WriteLine("==>invalid Output!!!!!");
                                            goto BalanceValid;
                                        }
                                        if (record.Balance >= stockNo * i.StockPrice)
                                        {
                                            if (stockNo > 0 && stockNo < i.StockVolume)
                                            {
                                                i.StockVolume -= stockNo;
                                                i.StockValue += stockNo * i.StockPrice;
                                                record.StockDetails[stockName] += stockNo;
                                                record.Balance -= stockNo * i.StockPrice;
                                                record.Total_Shares = record.StockDetails["HDFCBANK"] + record.StockDetails["RELIANCE"] + record.StockDetails["TCS"] + record.StockDetails["INFOSYS"] + record.StockDetails["ICICIBANK"] + record.StockDetails["TATA"];
                                                Transaction.TransactionList newObj = new Transaction.TransactionList();
                                                newObj.Customer_Id = record.Customer_Id;
                                                newObj.Symbol = i.Symbol;
                                                newObj.UserName = record.UserName;
                                                newObj.Sell = 0;
                                                newObj.Buys = stockNo;
                                                newObj.ShareValue = (stockNo * i.StockPrice);
                                                transaction.Transaction_List.Add(newObj);
                                                File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\CustomerRecords.json", JsonConvert.SerializeObject(customer));
                                                File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\StockAccount.json", JsonConvert.SerializeObject(stockAccount));
                                                File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\Stock Data Processing\Transaction.json", JsonConvert.SerializeObject(transaction));
                                                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t*****Customer data******" + "\n\t\t\tCustomer Id: " + record.Customer_Id + "\t\t\tUserName: " + record.UserName + "\n\t\t\tTotal_Shares:" + record.Total_Shares + "\t\t\tBalance:" + record.Balance);
                                                Console.Write("\t\t\tStock==>");
                                                foreach (KeyValuePair<string, int> val in record.StockDetails)
                                                {
                                                    if (val.Value > 0)
                                                    {
                                                        Console.Write(val.Key + ": " + val.Value + "\t");
                                                    }
                                                }
                                                Console.WriteLine("\n\n");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You have insufficient Balance for buying " + stockName + "Stock");
                                            goto BalanceValid;
                                        }
                                    }
                                }
                                if (!validStock)
                                {
                                    Console.WriteLine("Invalid Input!!!, Please Enter input again:");
                                    goto stockvalid;
                                }
                            break;
                        case 3:
                                
                                foreach(Transaction.TransactionList tracks in transaction.Transaction_List)
                                {
                                    Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t*****Transaction Details******" +
                                    "\n\t\tCustomer Id: " + tracks.Customer_Id + "\t\tUserName: " + tracks.UserName + "\t\tSymbol: " + tracks.Symbol + "\n\t\tShares Bought:" + tracks.Buys + "\t\tShares sold:" + tracks.Sell + "\t\tShare value:" + tracks.ShareValue);
                                    Console.WriteLine("\n\n");
                                }
                                break;
                        case 4:
                            validation = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Input!!!, Please Enter input again:");
                            break;
                        }
                        if (validation)
                        {
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input!!! it throwing following exception.\n"+e+"\nPlease Enter input again:");
                }
            }
            Console.ReadKey();
        }
    }
}
