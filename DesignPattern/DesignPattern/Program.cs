﻿using System;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    { 
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------Singleton------------------ \n1.Singleton Structure \n2.Thread Safe Singleton \n3.Eager Initialization" +
                "\n4.Lazy Initialization\nEnter your options:");
            int options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1:
                    SingletonStructure();
                    break;

                case 2:
                    Parallel.Invoke(
                        () => ThreadOne(),()=> ThreadTwo());
                    break;
                case 3:
                    EagerInitialization();
                    break;
                case 4:
                    LazyInitialization();
                    break;
                case 5:
                    Console.WriteLine("1.PC \n2Servers \nEnter your options:");
                    int optionOne = Convert.ToInt32(Console.ReadLine());
                    switch (optionOne)
                    {
                        case 1:
                            FactoryPattern.ComputerFactory.Computer_Factory("PC");
                            break;
                        case 2:
                            FactoryPattern.ComputerFactory.Computer_Factory("Servers");
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
        
        /*--------------------------------------------------------- Static Methods ----------------------------------------------------------------------------------*/
        private static void LazyInitialization()
        {
            Lazy_Initialization lazy = Lazy_Initialization.GetInstance();
            lazy.Instance("check Lazy 1");
            lazy.Instance("check Lazy 2");
            Lazy_Initialization lazyOne = Lazy_Initialization.GetInstance();
            lazyOne.Instance("check eager 4");
            lazyOne.Instance("check eager 3");
        }
        private static void EagerInitialization()
        {
            Eager_Initialize eager = Eager_Initialize.GetInstance();
            eager.Instance("check eager 1");
            eager.Instance("check eager 2");
            Eager_Initialize eager1 = Eager_Initialize.GetInstance();
            eager1.Instance("check eager 4");
            eager1.Instance("check eager 3");
        }
        private static void SingletonStructure()
        {
            Singleton_Structure singleton = Singleton_Structure.GetInstance();
            singleton.Instance("check Singleton 1");
            singleton.Instance("check Singleton 2");
            Console.WriteLine("-------------------------------------------------------------");
            Singleton_Structure singleton1 = Singleton_Structure.GetInstance();
            singleton1.Instance("check Singleton1 3");
            singleton1.Instance("check Singleton1 4");
        }
        private static void ThreadOne()
        {
            Thread_Safety singleton = Thread_Safety.GetInstance();
            singleton.Instance("check Singleton 1");
            singleton.Instance("check Singleton 2");
        }
        private static void ThreadTwo()
        {
            Thread_Safety singleton = Thread_Safety.GetInstance();
            singleton.Instance("check Singleton 3");
            singleton.Instance("check Singleton 4");
        }
    }
}
