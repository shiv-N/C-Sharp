using System;
using System.IO;
using Newtonsoft.Json;

namespace test
{
    class Program
    {

        public static void Main(string[] args)
        {
            Stock.LinkList utility = new Stock.LinkList();
            utility.InsertFront("TCS", 55333, 1200);
            //Console.WriteLine("enter symbol:");
            //string symbol = Console.ReadLine();
            //Console.WriteLine("enter shares volume:");
            //int volume = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter share's price:");
            //int price = Convert.ToInt32(Console.ReadLine());
            utility.InsertLast("RBI", 8855333, 2200);
            utility.InsertLast("INTEL", 40000, 1500);
            utility.InsertLast("Oracle", 40800, 1400);
            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\test\output.json", JsonConvert.SerializeObject(utility));
            Console.ReadKey();
        }
    }
}
//using System;

//using System.Collections.Generic;



//namespace test

//{

//    /// <summary>

//    /// MainApp startup class for Real-World 

//    /// Singleton Design Pattern.

//    /// </summary>

//    class Program

//    {

//        /// <summary>

//        /// Entry point into console application.

//        /// </summary>

//        static void Main()

//        {

//            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();

//            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();

//            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();

//            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();



//            // Same instance?

//            if (b1 == b2 && b2 == b3 && b3 == b4)

//            {

//                Console.WriteLine("Same instance\n");

//            }



//            // Load balance 15 server requests

//            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

//            for (int i = 0; i < 15; i++)

//            {

//                string server = balancer.Server;

//                Console.WriteLine("Dispatch Request to: " + server);

//            }



//            // Wait for user

//            Console.ReadKey();

//        }

//    }



//    /// <summary>

//    /// The 'Singleton' class

//    /// </summary>

//    class LoadBalancer

//    {

//        private static LoadBalancer _instance;

//        private List<string> _servers = new List<string>();

//        private Random _random = new Random();



//        // Lock synchronization object

//        private static object syncLock = new object();



//        // Constructor (protected)

//        protected LoadBalancer()

//        {

//            // List of available servers

//            _servers.Add("ServerI");

//            _servers.Add("ServerII");

//            _servers.Add("ServerIII");

//            _servers.Add("ServerIV");

//            _servers.Add("ServerV");

//        }



//        public static LoadBalancer GetLoadBalancer()

//        {

//            // Support multithreaded applications through

//            // 'Double checked locking' pattern which (once

//            // the instance exists) avoids locking each

//            // time the method is invoked

//            if (_instance == null)

//            {

//                lock (syncLock)

//                {

//                    if (_instance == null)

//                    {

//                        _instance = new LoadBalancer();

//                    }

//                }

//            }



//            return _instance;

//        }



//        // Simple, but effective random load balancer

//        public string Server

//        {

//            get

//            {

//                int r = _random.Next(_servers.Count);

//                return _servers[r].ToString();

//            }

//        }

//    }

//}
