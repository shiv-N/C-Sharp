using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    class InsertionSort
    {
        public void Insertion_Sort()
        {
            Console.WriteLine("enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("enter string elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }
            for(int i = 1; i < array.Length; i++)
            {
                string key = array[i];
                int j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(key) > 0))
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
            
            for(int i=0;i<array.Length;i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
