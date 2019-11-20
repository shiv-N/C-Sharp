using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class PrimeNumbers
    {
        public void CheckPrime()
        {
            int[] prime = new int[200];
            prime[0] = 2;
            int index=1,i = 3;
            while (i <= 1000)
            {
                bool valid = false;
                for (int j = 2; j <= i / 2; j++)
                {
                    if(i%j == 0)
                    {
                        valid = true;
                    }
                }
                if(valid == false)
                {
                    prime[index] = i;
                    index++;
                }
                i++;
            }
            int[] range = new int[] { 0, 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
            for(int k = 0; k < range.Length - 1; k++)
            {
                for(int j= 0;j < prime.Length;j++)
                {
                    if(range[k]<prime[j] && range[k + 1] > prime[j])
                    {
                        Console.Write(prime[j] + " ");
                    }
                }
                Console.WriteLine();
            }
            int[] anagram = new int[100];
            index = 0;
            StackUtility utility = new StackUtility();
            for(int j = 0; j < prime.Length; j++)
            {
                int temp=0,count=prime[j];
                while (count > 0)
                {
                    int r = count % 10;  //getting remainder  
                    temp = (temp * 10) + r;
                    count = count / 10;
                }
                for(int k=j+1;k < prime.Length; k++)
                {
                    if (prime[k] > temp + 1 || index==100)
                    {
                        break;
                    }
                    bool valid = utility.IsAnagram(prime[j], prime[k]);
                    if (valid)
                    {
                        anagram[index] = prime[j];
                        index++;
                        anagram[index] = prime[k];
                        index++;
                    }
                    
                }
            }
            Console.WriteLine("Prime anagram number:");
            for (int k = 0; k < anagram.Length; k++)
            {
                Console.Write(anagram[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
