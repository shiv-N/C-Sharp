using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Replace
    {
        public void ReplaceStringElements()
        {
            string testString = "Hello <<name>>, We have your full name as <<full name>> " +
              "in our system. your contact number is +91-xxxxxxxxxx. \nPlease,let us know in case of " +
             "any clarification Thank you Bridgelabz 01/01/2016.";
            //<<(?<tagName>[^>]+)>>|
            Regex regex = new Regex(@"(<<(?<tagName>[^>]+)>>)|(-(?<tagName>[a-z])+\.)");
            //Match match = regex.Match(testString);
            //Console.WriteLine("val="+match.Value);
            string cleanString = regex.Replace(testString, ProcessHtmlTag);
            Console.WriteLine(cleanString);
        }
        private static string ProcessHtmlTag(Match m)
        {
            string tagName = m.Groups["tagName"].Value;
            switch (tagName)
            {
                case "name":
                    bool validOne = false;
                    while (!validOne)
                    {
                        Console.WriteLine("enter your initial name:");
                        string name = Console.ReadLine();
                        Regex regex = new Regex("^[a-zA-Z]{1,10}$");
                        Match match = regex.Match(name);
                        if (match.Success)
                        {
                            tagName = name;
                            validOne = true;

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!!");
                        }
                    }
                    break;
                case "full name":
                    bool validTwo = false;
                    while (!validTwo)
                    {
                        Console.WriteLine("enter your full name:");
                        string fullName = Console.ReadLine();
                        Regex regex = new Regex("^[a-zA-Z]{1,10}$|^([a-zA-Z]{1,10}) ([a-zA-Z]{1,10})$|^([a-zA-Z]{1,10}) ([a-zA-Z]{1,10}) ([a-zA-Z]{1,10})$");
                        Match match = regex.Match(fullName);
                        if (match.Success)
                        {
                            tagName = fullName;
                            validTwo = true;

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!!");
                        }
                    }
                    break;

                case "x":
                    bool validThree = false;
                    while (!validThree)
                    {
                        Console.WriteLine("enter your phone number:");
                        string phNumber = Console.ReadLine();
                        Regex regex = new Regex("^[0-9]{10}$");
                        Match match = regex.Match(phNumber);
                        if (match.Success)
                        {
                            tagName = phNumber+".";
                            validThree = true;

                        }
                        else
                        {
                            Console.WriteLine("Invalid Input!!");
                        }
                    }
                    break;
            }
            return tagName.ToLower();
        }
    }
}
