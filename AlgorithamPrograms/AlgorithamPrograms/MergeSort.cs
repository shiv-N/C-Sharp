using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    class MergeSort
    {
        public void Merge_Sort()
        {
            Console.WriteLine("enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("enter string elements of array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Sort(array, 0, size - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
        public static int Sort(int[] array, int firstValue, int lastValue)
        {
            if (lastValue > firstValue)
            {
                int mid = (firstValue + lastValue) / 2;

                Sort(array, firstValue, mid);
                Sort(array, mid + 1, lastValue);

                Merge(array, firstValue, mid, lastValue);
            }
            return -1;
        }
        public static void Merge(int[] array,int firstValue,int mid,int lastvalue)
        {
            int size1 = mid - firstValue + 1;
            int size2 = lastvalue - mid;

            int[] firstArray = new int[size1];
            int[] secondArray = new int[size2];

            for (int i = 0; i < size1; i++)
            {
                firstArray[i] = array[firstValue + i];
            }
            for (int i = 0; i < size1; i++)
            {
                secondArray[i] = array[mid+1+ i];
            }

            int x = 0, y = 0;
            int k = firstValue;
            while(x<size1 && y < size2)
            {
                if (firstArray[x] > secondArray[y])
                {
                    array[k] = secondArray[y];
                    y++;
                }
                else
                {
                    array[k] = firstArray[x];
                    x++;
                }
                k++;
            }
            while (x < size1)
            {
                array[k] = firstArray[x];
                x++;
                k++;
            }
            while (y < size2)
            {
                array[k] = secondArray[y];
                y++;
                k++;
            }
        }
    }
}
