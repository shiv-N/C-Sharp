//-----------------------------------------------------------------------
// <copyright file="Inventory.cs" company="Bridgelabz">
//    Copyright © 2019 Company
// </copyright>
// <creator name="Saurabh Navdkar"/>
// -----------------------------------------------------------------------
namespace OOPS
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// this is class Inventory.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// Method that convert the text file to .net object
        /// </summary>
        public void JsonDeserilaize()
        {
            // create obj of InventoryManager to access properties of InventoryManager
            InventoryManager manager = new InventoryManager();
            // deserialize json file to object
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json"));
            // options
            Console.WriteLine("1. Display Inventory\n2. Add to Inventory\n3. Remove from Inventory\n4. Update to Inventory\nEnter your Option:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("1.Rice\n2.Pulse\n3.Wheats\nEnter your option:");
                    int displayOption = Convert.ToInt32(Console.ReadLine());
                    switch (displayOption)
                    {
                        case 1:
                            // display inventory list of rice
                            manager.DisplayInventory(utility.RiceList);
                            break;
                        case 2:
                            // display inventory list of pulses
                            manager.DisplayInventory(utility.PulseList);
                            break;
                        case 3:
                            // display inventory list of wheat
                            manager.DisplayInventory(utility.WheatsList);
                            break;
                        default:
                            // switch case default message
                            Console.WriteLine("Invalid Input!!!!!!!!!!");
                            break;

                    }
                    break;
                case 2:
                    // options
                    Console.WriteLine("\n1. Add Record to Rice\n2. Add Record to pulse\n3. Add Record to wheat\nEnter your Option:");
                    int optionOne = Convert.ToInt32(Console.ReadLine());
                    switch (optionOne)
                    {
                        case 1:
                            // add records to inventory
                            utility.RiceList = manager.AddToInventory(utility.RiceList);
                            // update added record to json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            // add records to inventory
                            utility.PulseList = manager.AddToInventory(utility.PulseList);
                            // update added record to json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            // add records to inventory
                            utility.WheatsList = manager.AddToInventory(utility.WheatsList);
                            // update added record to json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            // switch case default message
                            Console.WriteLine("Invalid Input!!!!!!!!!!");
                            break;
                    }
                    break;
                case 3:
                    // options
                    Console.WriteLine("\n1. remove Record from Rice\n2. remove Record from pulse\n3. remove Record from wheat\nEnter your Option:");
                    int optionTwo = Convert.ToInt32(Console.ReadLine());
                    switch (optionTwo)
                    {
                        case 1:
                            // display inventory list
                            manager.DisplayInventory(utility.RiceList);
                            // remove record from inventory
                            utility.RiceList = manager.RemoveFromInventory(utility.RiceList);
                            // update json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            // display inventory list
                            manager.DisplayInventory(utility.PulseList);
                            // remove record from inventory
                            utility.PulseList = manager.RemoveFromInventory(utility.PulseList);
                            // update json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            // display inventory list
                            manager.DisplayInventory(utility.WheatsList);
                            // remove record from inventory
                            utility.WheatsList = manager.RemoveFromInventory(utility.WheatsList);
                            // update json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            // switch case default message
                            Console.WriteLine("Invalid Input!!!!!!!!!!");
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("\n1. Update Record to Rice\n2. Update Record to pulse\n3. Update Record to wheat\nEnter your Option:");
                    int optionThree = Convert.ToInt32(Console.ReadLine());
                    switch (optionThree)
                    {
                        case 1:
                            // display inventory list
                            manager.DisplayInventory(utility.RiceList);
                            // update a perticular record from a list
                            utility.RiceList = manager.UpdateToInventory(utility.RiceList);
                            // update json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        case 2:
                            // display inventory list
                            manager.DisplayInventory(utility.PulseList);
                            // update a perticular record from a list
                            utility.PulseList = manager.UpdateToInventory(utility.PulseList);
                            // update json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        case 3:
                            // display inventory list
                            manager.DisplayInventory(utility.WheatsList);
                            // update a perticular record from a list
                            utility.WheatsList = manager.UpdateToInventory(utility.WheatsList);
                            // update json file by serializing
                            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\json.json", JsonConvert.SerializeObject(utility));
                            break;
                        default:
                            Console.WriteLine("Invalid Input!!!!!!!!!!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!!!!!!!!");
                    break;

            }
            
            //File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\OOPS\OOPS\output.json", JsonConvert.SerializeObject(utility));
        }
    }
}
