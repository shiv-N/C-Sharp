using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class StackUtility
    {
        public bool IsAnagram(int firstInput, int secondInput)
        {
            string string1 = Convert.ToString(firstInput);
            string string2 = Convert.ToString(secondInput);
            char[] charArray1 = string1.ToCharArray();
            char[] charArray2 = string2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            string resultString1 = new string(charArray1);
            string resultString2 = new string(charArray2);
            int result = string.Compare(resultString1, resultString2);
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
