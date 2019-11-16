using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    class BubbleSort
    {
        public void Bubble_Sort()
        {
            Console.WriteLine("enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter string elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < size; i++)
            {
                for(int j=0; j< size - i - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            BubbleSort.Print_Array(array);
        }

        public static void Print_Array(int[] array)
        {
            for(int i=0 ; i< array.Length;i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
