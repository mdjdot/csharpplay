using System;
using System.Text.RegularExpressions;

namespace RegexApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1851 1999 1950 1905 2003";
            string pattern = @"(\d{2})\d{2}\b";

            foreach (Match item in Regex.Matches(input, pattern))
            {
                Console.WriteLine(item.Value);
                foreach (Group group in item.Groups)
                {
                    System.Console.WriteLine(group.Value);
                }
            }


        }
    }
}
