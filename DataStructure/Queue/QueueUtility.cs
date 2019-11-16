using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Bank
    {
        public int balance;

    }
    public class Node
    {
        public string Name;
        public int balance;
        public Node next;
        public Node(string Name)
        {
            this.Name = Name;
        }
    }
    class QueueUtility
    {
        Node front, rear;
        Bank bank = new Bank();
        public void AddMoneyRecords(Bank newNode)
        {
            this.bank.balance = newNode.balance;
        }
        public void ShowCustomerStatus(Node newNode)
        {
            QueueUtility utility = new QueueUtility();
            Console.WriteLine("Customer Name=" +newNode.Name+
                "\n Customer Balance="+newNode.balance);
            validTwo:
            Console.WriteLine("1.Deposite \n2.Withdrawal \n" +"3.exit\n"+
               "4.Bank Status \nenter your option.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("enter amount to deposite:");
                    int deposite = Convert.ToInt32(Console.ReadLine());
                    newNode.balance += deposite;
                    bank.balance += newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 2:
                    Console.WriteLine("enter amount to withdrawal:");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());
                    newNode.balance -= withdrawal;
                    bank.balance -= newNode.balance;
                    utility.AddMoneyRecords(bank); 
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 3:
                    utility.Dequeue();
                    Console.WriteLine("customer is out of the queue.");
                    break;

                case 4: Console.WriteLine("Bank Balance="+this.bank.balance);
                    goto validTwo;

                default:
                    Console.WriteLine("invalid input!! enter your option again:");
                    goto validTwo;
            }
        }
        public void EnQueue(string Name,int balance)
        {
            this.bank.balance = 10000000;
            QueueUtility utility = new QueueUtility();
            Node newNode = new Node(Name);
            newNode.balance = balance;
            //bank.balance += newNode.balance;
            //utility.AddMoneyRecords(bank);
            if (rear == null)
            {
                front = rear = newNode;
            }
            rear.next = newNode;
            rear = newNode;
            Console.WriteLine("1.Deposite \n2.Withdrawal \n" +
                "enter your option.");
            validOne:
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: Console.WriteLine("enter amount to deposite:");
                        int deposite = Convert.ToInt32(Console.ReadLine());
                    newNode.balance += deposite;
                    bank.balance += newNode.balance;
                    utility.AddMoneyRecords(bank); 
                    utility.ShowCustomerStatus(newNode);
                    break;

                case 2:
                    Console.WriteLine("enter amount to withdrawal:");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());
                    newNode.balance -= withdrawal;
                    bank.balance -= newNode.balance;
                    utility.AddMoneyRecords(bank);
                    utility.ShowCustomerStatus(newNode);
                    break;
                default:
                    Console.WriteLine("invalid input!! enter your option again:");
                    goto validOne;
            }
        }

        public void Dequeue()
        {
            if(front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            front = front.next;
            Console.WriteLine("Element is deleted");
            if (front == null)
            {
                rear = null;
            }
        }

        public void DisplayQueue()
        {
            Node current = front;

            if(current == null)
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            {
                while(current != null)
                {
                Console.Write(current.Name + "-->");
                current = current.next;
                }
                Console.WriteLine();
            }
        }

        /*******************************************************************Calender Utility***************************************************************/
        public static bool LeapYear(int year)
        {
            if (year % 4 == 0)
            {                                                           // A leap year is exactly divisible by 4 except for century years (years ending with 00).
                if (year % 100 == 0)
                {                                                   // The century year is a leap year only if it is perfectly divisible by 400.
                    if (year % 400 == 0)
                    {                                                // only if it is perfectly divisible by 400.
                        return true;                                  // by using modulous(%) it checks if it is divisible or not.
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public int GetLast_Date(int month,int year)
        {
            int[] lastDates = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if(month == 2)
            {
                if (LeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return lastDates[month - 1];
                }
            }
            else
            {
                return lastDates[month - 1];
            }
        }

        public int GetFirst_Date(int m, int d, int y)
        {
            int y1 = y - ((14 - m) / 12);
            int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
            int m1 = m + (12 * ((14 - m) / 12)) - 2;
            int d1 = (d + x + ((31 * m1) / 12)) % 7;
            return d1;
        }

        public string[,] GetCalenderArray(int firstDay,int lastDay)
        {
            string[,] calenderArray = new string[6, 7];
            int date = 1;
            for(int i=0; i < 6; i++)
            {
                if (i == 0)
                {
                    for (int j=7-firstDay;j<7;j++)
                    {
                        calenderArray[i, j] += date;
                        date++;
                    }
                }
                else
                {
                    for(int j = 0; j < 7; j++)
                    {
                        if(date <= lastDay)
                        {
                        calenderArray[i, j] += date;
                        date++;
                        }
                    }

                }
            }
            return calenderArray;
        }
    }
}
