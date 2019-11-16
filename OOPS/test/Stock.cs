using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Stock
    {
            public LinkList Stocks { get; set; }

            public class StockRecords
            {
                public string Symbol { get; set; }
                public int Volume { get; set; }
                public int Price { get; set; }
            }
    /*********************************** class LinkList ******************************/
    public class LinkList
    {
            public class Node
            {
                public string Symbol;
                public int Volume;
                public int Price;

                public int idata;
                public Node next;

                public Node(string data,int volume,int price)
                {
                    this.Volume = volume;
                    this.Price = price;
                    Symbol = data;
                    next = null;
                }
                public Node(int data)
                {
                    this.idata = data;
                    next = null;
                }
            }
            Node head;
        /***************************************insertFront method************************/
        public void InsertFront(string data,int volume,int price)
        {
            Node newNode = new Node(data,volume,price);
            newNode.next = head;
            head = newNode;
        }
         public Node CompanyStocks { get { return head; } set { CompanyStocks = head; } }
            public void InsertLast(string data, int volume, int price)
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                Node newNode = new Node(data, volume, price);
                current.next = newNode;
            }
        // public bool InsertSorted(int data)
        // {
        //    Node newNode = new Node(data);
        //    Node current = head;
        //    Node previous = head;
        //    if (head == null)
        //    {
        //        newNode.next = head;
        //        head = newNode;
        //        return true;
        //    }
        //    else
        //    {
        //        if (current.idata >= newNode.idata)
        //        {
        //            newNode.next = head;
        //            head = newNode;
        //            Console.WriteLine(current.data);
        //            return true;
        //        }
        //        while (current.idata < newNode.idata)
        //        {
        //            if (current.next == null)
        //            {
        //                break;
        //            }
        //            previous = current;
        //            current = current.next;
        //        }
        //        if (previous.idata < newNode.idata && newNode.idata < current.idata)
        //        {
        //            newNode.next = previous.next;
        //            previous.next = newNode;
        //            return true;
        //        }
        //        else
        //        {
        //            newNode.next = current.next;
        //            current.next = newNode;
        //            return true;
        //        }
        //    }
        //}
        ///***************************************insertNextToKey method************************/
        //public bool InsertNextTOKey(string key, string data)
        //{
        //    Node current = head;
        //    while (current.data != key)
        //    {
        //        if (current.next == null)
        //        {
        //            break;
        //        }
        //        current = current.next;
        //    }
        //    if (current.data == key)
        //    {
        //        Node newNode = new Node(data);
        //        newNode.next = current.next;
        //        current.next = newNode;
        //        Console.WriteLine("element is added to list");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("key is not in the list");
        //        return false;
        //    }
        //}
        ///*************************************DisplayStringList method************************/
        //public void DisplayIntList()
        //{
        //    Node current = head;
        //    if (head != null)
        //    {
        //        while (current != null)
        //        {
        //            Console.Write(current.idata + "-->");
        //            current = current.next;
        //        }
        //        Console.Write("null");
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is empty");
        //    }
        //}
        ///*************************************DisplayStringList method************************/
        //public void DisplayStringList()
        //{
        //    Node current = head;
        //    if (head != null)
        //    {
        //        while (current != null)
        //        {
        //            Console.Write(current.data + "-->");
        //            current = current.next;
        //        }
        //        Console.Write("null");
        //        Console.WriteLine();
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is empty");
        //    }
        //}
        ///***************************************ReturnString method************************/
        //public string ReturnString()
        //{
        //    string stringText = "";
        //    Node current = head;
        //    if (head != null)
        //    {
        //        stringText += current.data;
        //        current = current.next;
        //        while (current != null)
        //        {
        //            stringText = stringText + " " + current.data;
        //            current = current.next;
        //        }
        //        return stringText;
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is empty");
        //        return null;
        //    }
        //}
        ///***************************************ReturnString method************************/
        //public string ReturnNumberString()
        //{
        //    string stringText = "";
        //    Node current = head;
        //    if (head != null)
        //    {
        //        stringText += current.idata;
        //        current = current.next;
        //        while (current != null)
        //        {
        //            stringText = stringText + " " + current.idata;
        //            current = current.next;
        //        }
        //        return stringText;
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is empty");
        //        return null;
        //    }
        //}
        ///***************************************ReturnString method***********************
        //public int ReturnIntArray()
        //{
        //    int[] intArray = new int[1000];
        //    Node current = head;
        //    if (head != null)
        //    {
        //        int i = 0;
        //        while (current != null)
        //        {
        //            intArray[i] = current.idata;
        //            current = current.next;
        //            i++;
        //        }
        //        return intArray;
        //    }
        //    else
        //    {
        //        Console.WriteLine("List is empty");
        //        return null;
        //    }
        //}
        //*/
        ///***************************************Search-string method************************/
        //public bool Search(string key)
        //{
        //    Node current = head;
        //    if (head == null)
        //    {
        //        Console.WriteLine("List is empty so none element deleted");
        //        return false;
        //    }
        //    while (current.data != key)
        //    {
        //        if (current.next == null)
        //        {
        //            break;
        //        }
        //        current = current.next;
        //    }
        //    if (current.data == key)
        //    {
        //        Console.WriteLine("element found in list");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("element is not in list");
        //        return false;
        //    }
        //}
        ///***************************************Search-integer method************************/
        //public bool SearchInt(int key)
        //{
        //    Node current = head;
        //    if (head == null)
        //    {
        //        Console.WriteLine("List is empty so none element deleted");
        //        return false;
        //    }
        //    while (current.idata != key)
        //    {
        //        if (current.next == null)
        //        {
        //            break;
        //        }
        //        current = current.next;
        //    }
        //    if (current.idata == key)
        //    {
        //        Console.WriteLine("element found in list");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("element is not in list");
        //        return false;
        //    }
        //}
        ///***************************************DeleteFront method************************/
        //public void DeleteFront()
        //{
        //    if (head == null)
        //    {
        //        Console.WriteLine("List is empty so none element deleted");
        //    }
        //    else if (head.next == null)
        //    {
        //        head = null;
        //    }
        //    else
        //    {
        //        head.data = head.next.data;
        //        head.next = head.next.next;
        //    }
        //}
        ///***************************************DeleteKeyElement(string) method************************/
        //public bool DeleteKeyElement(string key)
        //{
        //    Node current = head;
        //    Node previous = head;
        //    if (current.data == key)
        //    {
        //        head.data = head.next.data;
        //        head.next = head.next.next;
        //        Console.WriteLine("1st element deleted from the list");
        //        return true;
        //    }
        //    else
        //    {
        //        current = current.next;
        //    }
        //    while (current.data != key)
        //    {
        //        if (current.next == null)
        //        {
        //            break;
        //        }
        //        previous = current;
        //        current = current.next;
        //    }
        //    if (current.data == key)
        //    {
        //        previous.next = current.next;
        //        Console.WriteLine("element  deleted from the list");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("element is not in list");
        //        return false;
        //    }
        //}
        ///***************************************DeleteKeyElement(string) method************************/
        //public bool DeleteIntKeyElement(int key)
        //{
        //    Node current = head;
        //    Node previous = head;
        //    if (current.idata == key)
        //    {
        //        head.data = head.next.data;
        //        head.next = head.next.next;
        //        Console.WriteLine("1st element deleted from the list");
        //        return true;
        //    }
        //    else
        //    {
        //        current = current.next;
        //    }
        //    while (current.idata != key)
        //    {
        //        if (current.next == null)
        //        {
        //            break;
        //        }
        //        previous = current;
        //        current = current.next;
        //    }
        //    if (current.idata == key)
        //    {
        //        previous.next = current.next;
        //        Console.WriteLine("element  deleted from the list");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("element is not in list");
        //        return false;
        //    }
        //}
        // end of all methods.
    }
    }
}
