using System;

namespace EnumApplication
{
    enum Day
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Day.Fri); // Fri
            Console.WriteLine((int)Day.Fri); // 5
        }
    }
}
