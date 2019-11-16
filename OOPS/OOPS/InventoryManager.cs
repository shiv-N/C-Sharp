using System;
using System.Collections.Generic;

namespace OOPS
{
    class InventoryManager
    {
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> riceList)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            
            Console.WriteLine("enter Name of rice:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("enter price of rice:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter weight in kg of rice:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of rice:");
            utility.Type = Console.ReadLine();
            riceList.Add(utility);
            return riceList;
        }
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulses)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();

            Console.WriteLine("enter Name of pulse:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("enter price of pulse:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter weight in kg of pulse:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of pulse:");
            utility.Type = Console.ReadLine();
            pulses.Add(utility);
            return pulses;
        }
        public List<InventoryUtility.Wheats> AddToInventory(List<InventoryUtility.Wheats> wheats)
        {
            InventoryUtility.Wheats utility = new InventoryUtility.Wheats();
            
            Console.WriteLine("enter Name of wheats:");
            utility.Name = Console.ReadLine();
            Console.WriteLine("enter price of wheats:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter weight in kg of wheats:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of wheats:");
            utility.Type = Console.ReadLine();
            wheats.Add(utility);
            return wheats;
        }
        public List<InventoryUtility.Rice> UpdateToInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("enter Name of rice to be updated:");
            string Name = Console.ReadLine();
            rice.Remove(rice.Find(ut => ut.Name.Equals(Name)));

            Console.WriteLine("enter price of rice :");
            utility.Name = Console.ReadLine();
            Console.WriteLine("enter price of rice:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter weight in kg of rice:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of rice:");
            utility.Type = Console.ReadLine();
            rice.Add(utility);
            return rice;
        }
        public List<InventoryUtility.Pulse> UpdateToInventory(List<InventoryUtility.Pulse> pulses)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("enter Name of pulse to be updated:");
            string Name = Console.ReadLine();

            pulses.Remove(pulses.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("enter Name of pulse :");
            utility.Name = Console.ReadLine();
            Console.WriteLine("enter price of pulse:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter weight in kg of pulse:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of pulse:");
            utility.Type = Console.ReadLine();
            pulses.Add(utility);
            return pulses;
        }
        public List<InventoryUtility.Wheats> UpdateToInventory(List<InventoryUtility.Wheats> wheats)
        {
            InventoryUtility.Wheats utility = new InventoryUtility.Wheats();
            Console.WriteLine("enter Name of wheats to be updated:");
            string Name = Console.ReadLine();
            
            wheats.Remove(wheats.Find(ut => ut.Name.Equals(Name)));
            Console.WriteLine("enter Name of wheats :");
            utility.Name = Console.ReadLine();
            Console.WriteLine("enter price of wheats:");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter weight in kg of wheats:");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter type of wheats:");
            utility.Type = Console.ReadLine();
            wheats.Add(utility);
            return wheats;
        }

        public List<InventoryUtility.Rice> RemoveFromInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Wheats utility = new InventoryUtility.Wheats();
            Console.WriteLine("enter Name of rice to be deleted:");
            string Name = Console.ReadLine();

            rice.Remove(rice.Find(ut => ut.Name.Equals(Name)));
            return rice;
        }
        public List<InventoryUtility.Pulse> RemoveFromInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Wheats utility = new InventoryUtility.Wheats();
            Console.WriteLine("enter Name of pulse to be deleted:");
            string Name = Console.ReadLine();

            pulse.Remove(pulse.Find(ut => ut.Name.Equals(Name)));
            return pulse;
        }
        public List<InventoryUtility.Wheats> RemoveFromInventory(List<InventoryUtility.Wheats> wheats)
        {
            InventoryUtility.Wheats utility = new InventoryUtility.Wheats();
            Console.WriteLine("enter Name of wheats to be deleted:");
            string Name = Console.ReadLine();

            wheats.Remove(wheats.Find(ut => ut.Name.Equals(Name)));
            return wheats;
        }
        public void DisplayInventory(List<InventoryUtility.Rice> rice)
        {
            Console.WriteLine("*****************************Rice Inventory**********************************");
            string riceString = string.Empty;
            int totalInventoryRice = 0;
            //// iterates RiceList by InventoryUtility.Rice data type
            foreach (InventoryUtility.Rice i in rice)
            {
                riceString = "\nname= " + i.Name + "\nweight= " + i.Kg + "\nPrice= " + i.Price + "\ntype= " + i.Type;
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
                Console.WriteLine(riceString);
            }
            Console.WriteLine("\nTotal inventory rice cost:" + totalInventoryRice);
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> pulse)
        {
            Console.WriteLine("*****************************Pulse Inventory**********************************");
            string pulseString = string.Empty;
            int totalInventoryPulse = 0;
            //// iterates PulseList by InventoryUtility.Pulse data type
            foreach (InventoryUtility.Pulse i in pulse)
            {
                pulseString = "\nname= " + i.Name + "\nweight= " + i.Kg + "\nPrice= " + i.Price + "\ntype= " + i.Type;
                totalInventoryPulse += ManageInventory(i.Kg, i.Price);
                Console.WriteLine(pulseString);
            }
            Console.WriteLine("\nTotal inventory cost:" + totalInventoryPulse);
        }
        public void DisplayInventory(List<InventoryUtility.Wheats> wheats)
        {
            Console.WriteLine("*****************************Wheats Inventory**********************************");
            string wheatString = string.Empty;
            int totalInventoryWheats = 0;
            //// iterates WheatsList by InventoryUtility.Wheats data type
            for (int i = 0; i < wheats.Count; i++)
            {
                InventoryUtility.Wheats c = wheats[i];
                wheatString = "\nIndex=" + i + "\nname= " + c.Name + "\nweight= " + c.Kg + "\nPrice= " + c.Price + "\ntype= " + c.Type;
                totalInventoryWheats += ManageInventory(c.Kg, c.Price);
                Console.WriteLine(wheatString);
            }
            Console.WriteLine("\nTotal inventory rice cost:" + totalInventoryWheats);
        }
        public int ManageInventory(int kg,int price)
        {
            return kg * price;
        }
    }
}
