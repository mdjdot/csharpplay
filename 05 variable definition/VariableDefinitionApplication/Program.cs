using System;

namespace VariableDefinitionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            double c;

            /* 实际初始化 */
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c); // a = 10, b = 20, c = 30


            int num;
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            Console.ReadLine();

        }
    }
}
