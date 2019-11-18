//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace DesignPattern
{
using System;
using System.Threading.Tasks;
using DesignPattern.BehavioralPattern.Observer_Pattern;
using DesignPattern.Dependency_Injection;

    /// <summary>
    /// This is main program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                // main options
                Console.WriteLine("\n1. Creational Design Pattern\n2. Structural Design Pattern\n3. Behavioral Design Pattern\nEnter your options:");
                int mainOptions = Convert.ToInt32(Console.ReadLine());
                switch (mainOptions)
                {
                    case 1:
                        // calling Creational Design Pattern
                        CreationalPattern();
                        break;
                    case 2:
                        // calling Structural Design Pattern
                        StructuralPattern();
                        break;
                    case 3:
                        Console.WriteLine("Observer design pattern");
                        ObserverPattern observer = new ObserverPattern();
                        observer.Pattern();
                        break;
                    case 4:
                        // dependancy Injection
                        CustomerService dependencyI = new CustomerService();
                        dependencyI.GetCustomerName(22);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Input, it throws exception as "+e.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// StructuralPattern method.
        /// </summary>
        private static void StructuralPattern()
        {
            Console.WriteLine("\n1. Adapter Design Pattern\n2. Proxy Design Pattern\nEnter your options:");
            int optionsTwo = Convert.ToInt32(Console.ReadLine());
            switch (optionsTwo)
            {
                case 1:
                    Test.AdapterPatternTest adapterPattern = new Test.AdapterPatternTest();
                    adapterPattern.Adapter_Pattern();
                    break;
                case 2:
                    ProxyPattern proxy = new ProxyPattern();
                    proxy.Pattern();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        /// <summary>
        /// Creational pattern.
        /// </summary>
        private static void CreationalPattern()
        {
            Console.WriteLine("\n1. Singleton Design Pattern\n2. Factory Design Pattern\n3. Prototype Design Pattern\nEnter your options:");
            int optionsOne = Convert.ToInt32(Console.ReadLine());
            switch (optionsOne)
            {
                case 1:
                    Singleton();
                    break;
                case 2:
                    Factory();
                    break;
                case 3:
                    Prototype();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        /// <summary>
        /// Prototypes this instance.
        /// </summary>
        private static void Prototype()
        {
            PrototypePattern.Prototype_Pattern prototype = new PrototypePattern.Prototype_Pattern();
            prototype.Pattern();
        }

        /// <summary>
        /// Factories this instance.
        /// </summary>
        private static void Factory()
        {
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
        }

        /// <summary>
        /// Singletons this instance.
        /// </summary>
        private static void Singleton()
        {
            Console.WriteLine("-------------------Singleton------------------" +
                "\n1.Singleton Structure \n2.Thread Safe Singleton \n3.Eager Initialization" +
                    "\n4.Lazy Initialization\nEnter your options:");
            int options = Convert.ToInt32(Console.ReadLine());

            switch (options)
            {
                case 1:
                    SingletonStructure();
                    break;

                case 2:
                    Parallel.Invoke(
                        () => ThreadOne(), () => ThreadTwo());
                    break;
                case 3:
                    EagerInitialization();
                    break;
                case 4:
                    LazyInitialization();
                    break;
            }
        }

        /*--------------------------------------------------------- Static Methods ----------------------------------------------------------------------------------*/
        
        /// <summary>
        /// Lazy initialization.
        /// </summary>
        private static void LazyInitialization()
        {
            Lazy_Initialization lazy = Lazy_Initialization.GetInstance();
            lazy.Instance("check Lazy 1");
            lazy.Instance("check Lazy 2");
            Lazy_Initialization lazyOne = Lazy_Initialization.GetInstance();
            lazyOne.Instance("check eager 4");
            lazyOne.Instance("check eager 3");
        }

        /// <summary>
        /// Eagers the initialization.
        /// </summary>
        private static void EagerInitialization()
        {
            Eager_Initialize eager = Eager_Initialize.GetInstance();
            eager.Instance("check eager 1");
            eager.Instance("check eager 2");
            Eager_Initialize eager1 = Eager_Initialize.GetInstance();
            eager1.Instance("check eager 4");
            eager1.Instance("check eager 3");
        }

        /// <summary>
        /// Singletons the structure.
        /// </summary>
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

        /// <summary>
        /// Threads the one.
        /// </summary>
        private static void ThreadOne()
        {
            Thread_Safety singleton = Thread_Safety.GetInstance();
            singleton.Instance("check Singleton 1");
            singleton.Instance("check Singleton 2");
        }

        /// <summary>
        /// Threads the two.
        /// </summary>
        private static void ThreadTwo()
        {
            Thread_Safety singleton = Thread_Safety.GetInstance();
            singleton.Instance("check Singleton 3");
            singleton.Instance("check Singleton 4");
        }
    }
}
