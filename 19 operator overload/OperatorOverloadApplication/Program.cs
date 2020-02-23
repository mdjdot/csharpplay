using System;

namespace OperatorOverloadApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box();
            b1.Length = 11;
            b1.Width = 13;
            Box b2 = new Box();
            b2.Length = 21;
            b2.Width = 33;
            Console.WriteLine(b1 + b2); // 32
        }
    }
}
