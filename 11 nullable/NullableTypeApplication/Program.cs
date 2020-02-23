using System;

namespace NullableTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 2;
            Console.WriteLine(num1); // 
            Console.WriteLine(num2); // 2

            // ?? 运算符
            int? num3 = num1 ?? num2;
            Console.WriteLine(num3); // 2
        }
    }
}
