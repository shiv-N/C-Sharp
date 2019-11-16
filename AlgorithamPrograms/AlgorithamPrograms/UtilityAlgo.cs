using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    class UtilityAlgo
    {
        public int BinarySearch(int[] array, int firstValue, int lastValue, int find)
        {
            if (lastValue >= firstValue) 
            { 
                int mid = firstValue + (lastValue - firstValue) / 2;
                if (array[mid] == find)
                {
                    Console.WriteLine("found the element:" + array[mid]);
                    return mid;
                }
                else if (array[mid] > find) 
                {
                    return this.BinarySearch(array, firstValue, mid - 1, find);
                }
                else
                {
                    return this.BinarySearch(array, mid + 1, lastValue, find);
                }
            }
            return -1;
        }
    }
}
