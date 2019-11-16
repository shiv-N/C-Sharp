using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CalenderQueue
    {
        public void GetCalender()
        {
            QueueUtility utility = new QueueUtility();
            Console.WriteLine("Enter a month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());
            int lastDate = utility.GetLast_Date(month, year);
            int firstday = utility.GetFirst_Date(month, 1, year);

            Console.WriteLine(firstday + "     //     " + lastDate);
            object[,] calenderArray = new object[6, 7];
            calenderArray = utility.GetCalenderArray((7 - firstday + 1), lastDate);
            object[] day = new object[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            for (int j = 0; j < day.Length; j++)
            {
                Console.Write(day[j] + " ");
            }
            Console.WriteLine();


            for (int i = 0; i < 6; i++)
            {
                if (i == 0 || i == 1)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(calenderArray[i, j] + "   ");
                    }
                }
                else
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(calenderArray[i, j] + "  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
