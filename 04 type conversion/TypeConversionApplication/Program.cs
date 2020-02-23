using System;

namespace TypeConversionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 隐式转换
            int n = 13;
            double d = n;
            Console.WriteLine(n); // 13
            Console.WriteLine(d); // 13

            // 显式转换
            double dd = 3.14;
            int nn = (int)dd;
            Console.WriteLine(dd); // 3.14
            Console.WriteLine(nn); // 3

           int d2 = Convert.ToInt32(dd);
           Console.WriteLine(d2); // 3
        }
    }
}
