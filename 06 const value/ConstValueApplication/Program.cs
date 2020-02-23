using System;

namespace ConstValueApplication
{
    class Program
    {
        class SampleClass
        {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
        static void Main(string[] args)
        {
            var num = 215u; // uint 215
            var num1 = 032U; // uint 32
            Console.WriteLine(num); // 215
            Console.WriteLine(num1); // 32

            SampleClass sc = new SampleClass(11, 22);
            Console.WriteLine($"x = {sc.x}, y = {sc.y}"); // x = 11, y = 22
            Console.WriteLine($"c1 = {SampleClass.c1}, c2 = {SampleClass.c2}"); // c1 = 5, c2 = 10
        }
    }
}
