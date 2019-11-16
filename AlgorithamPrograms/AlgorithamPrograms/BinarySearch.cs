using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    using System;
    public class BinarySearch
    {
        public void Search()
        {
            Console.WriteLine("enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter elements that want to find:");
            int searchElement = Convert.ToInt32(Console.ReadLine());
            UtilityAlgo utility = new UtilityAlgo();
            int index = utility.BinarySearch(array, 0, size - 1, searchElement);
            if (index == -1)
            {
                Console.WriteLine("Element is not present");
            }
            else
            {
                Console.WriteLine("& index of an array is " + index);
            }
        }
    }
}
