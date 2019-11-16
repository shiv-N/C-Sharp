using System;
using System.Text;
using System.IO;

namespace LinkedList
{
    class OrderedList
    {
        public void Ordered()
        {
            LinkList list = new LinkList();
            string text = File.ReadAllText(@"C:\Users\Admin\source\repos\Saurabh\DataStructure\LinkedList\inputNumber.txt", Encoding.UTF8);
            string[] stringSeparator = new string[] { " " };
            string[] textArray;
            textArray = text.Split(stringSeparator, StringSplitOptions.RemoveEmptyEntries);
            int[] textInteger = new int[textArray.Length];
            for(int i = 0; i < textArray.Length; i++)
            {
                textInteger[i] = Convert.ToInt32(textArray[i]);
            }
            for (int i = 0; i < textInteger.Length; i++)
            {
                Console.Write(textInteger[i] + " ");
            }
            for(int i = 0; i < textInteger.Length; i++)
            {
                list.InsertSorted(textInteger[i]);
            }
            list.DisplayIntList();
            Console.WriteLine("Enter a string which you want to be found:");
            int searchInt = Convert.ToInt32(Console.ReadLine());
            if (list.SearchInt(searchInt))
            {
                list.DeleteIntKeyElement(searchInt);
            }
            else
            {
                list.InsertSorted(searchInt);
            }
            list.DisplayIntList();
            string intString = list.ReturnNumberString();
            File.WriteAllText(@"C:\Users\Admin\source\repos\Saurabh\DataStructure\LinkedList\inputNumber.txt", intString);
        }
    }
}
