using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamPrograms
{
    class Anagram
    {
        public void Check_Anagram()
        {
            Console.WriteLine("enter a string 1:");
            string String1 = Console.ReadLine();
            Console.WriteLine("enter a string 2:");
            string String2 = Console.ReadLine();
            string newString1 = String1.Replace(" ", "");
            string newString2 = String2.Replace(" ", "");
            newString1 = newString1.ToLower();
            newString2 = newString2.ToLower();
            char[] charArray1 = newString1.ToCharArray();
            char[] charArray2 = newString2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            string resultString1 = new string(charArray1);
            string resultString2 = new string(charArray2);
            int result = string.Compare(resultString1, resultString2);
            if (result==0)
            {
                Console.WriteLine("Given strings are anagrams");
            }
            else
            {
                Console.WriteLine("Given strings are not anagrams");
            }
        }
    }
}
