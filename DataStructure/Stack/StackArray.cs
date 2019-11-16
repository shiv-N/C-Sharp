namespace Stack
{
    using System;

    class StackArray
    {
        private int top;
        private readonly int size;
        private readonly int[] stackArray;

        public StackArray(int size)
        {
            this.size = size;
            stackArray = new int[size];
            top = -1;
        }

        public bool Push(int data)
        {
            if (top >= (this.size-1))
            {
                Console.WriteLine("Overflow");
                return false;
            }
            else
            {
                top++;
                stackArray[top]= data;
                return true;
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Underflow");
                return -1;
            }
            else
            {
                int temp = stackArray[top];
                stackArray[top] = 0;
                top--;
                return temp;
            }
        }

        public int Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Underflow");
                return -1;
            }
            else
            {
                return stackArray[top];
            }
        }

        public bool IsEmpty()
        {
            return (top < 0)? true : false;
        }

        public void DisplayStack()
        {
            for(int i = 0; i <= top; i++)
            {
                Console.Write(stackArray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
