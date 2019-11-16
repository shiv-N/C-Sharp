using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    }
    class StackLinkedList
    {
        Node top;

        public void push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
               top = newNode;
            }
            else
            {
                Node temp = top;
                newNode.next = temp;
                top = newNode;
            }
        }

        public void DisplayList()
        {
            if (top.next != null)
            {
                Node current = top;
                while (current.next != null)
                {
                    Console.Write(current.data + "-->");
                    current = current.next;
                }
                Console.Write(current.data + "-->");
                Console.Write("null");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public void Pop()
        {
            if (top.next != null)
            {
                top.data = top.next.data;
                top.next = top.next.next;
            }
            else
            {
                Console.WriteLine("stack is empty. None values are deleted");
            }
        }

    }
}
