using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    using System;
    class BalanceParentheses
    {
        public void IsBalanceParentheses()
        {
            bool valid = false;
            Console.WriteLine("Enter Arithmetic Expression:");
            string expression = Console.ReadLine();
            char[] charArray = expression.ToCharArray();
            int size = charArray.Length;
            for(int j = 0; j < size; j++)
            {
                if (charArray[j] == '(' || charArray[j] == '{' || charArray[j] == '[' || charArray[j] == ')' || charArray[j] == '}' || charArray[j] == ']')
                {
                    valid = true;
                    break;
                }
            }
            if (valid)
            {
                StackArray stack = new StackArray(size);
                int i = 0;
                while (i < size)
                {
                    if (charArray[i] == '(' || charArray[i] == '{' || charArray[i] == '[')
                    {
                        stack.Push(charArray[i]);
                    }
                    else if(charArray[i] == ')' || charArray[i] == '}' || charArray[i] == ']')
                    {
                        stack.Pop();
                    }
                    i++;
                }
                if (stack.IsEmpty())
                {
                    Console.WriteLine("parentheses appeared in a balanced fashion");
                }
                else
                {
                    Console.WriteLine("parentheses are not appeared in a balanced fashion");
                }
            }
            else
            {
                Console.WriteLine("there is no parentheses!!!");
            }
        }
    }
}
