using System;

namespace OperatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 算数运算符
            int a = 21;
            int b = 10;
            int c;

            c = a + b;
            Console.WriteLine($"Line 1 - c 的值是{c}"); // 31
            c = a - b;
            Console.WriteLine($"Line 2 - c 的值是{c}"); // 11
            c = a * b;
            Console.WriteLine($"Line 2 - c 的值是{c}"); // 210
            c = a / b;
            Console.WriteLine($"Line 2 - c 的值是{c}"); // 2
            c = a % b;
            Console.WriteLine($"Line 2 - c 的值是{c}"); // 1

            // --a a-- ++a a++
            int i = 10;
            int j = 10;
            int m = ++i;
            int n = j++;
            Console.WriteLine(i); // 11
            Console.WriteLine(j); // 11
            Console.WriteLine(m); //11
            Console.WriteLine(n); // 10

            // 关系运算符
            int aa = 11;
            int bb = 12;
            if (aa > bb)
            {
                Console.WriteLine("Grater");
            }
            else if (aa == bb)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Less");
            }

            // 逻辑运算符
            bool bl1 = true;
            bool bl2 = false;
            if (bl1 && bl2)
            {
                Console.WriteLine("True");
            }

            // 位运算符
            int a1 = 60;            /* 60 = 0011 1100 */
            int b1 = 13;            /* 13 = 0000 1101 */
            int c1 = 0;

            c1 = a1 & b1;           /* 12 = 0000 1100 */
            Console.WriteLine("Line 1 - c 的值是 {0}", c1); // 12

            c1 = a1 | b1;           /* 61 = 0011 1101 */
            Console.WriteLine("Line 2 - c 的值是 {0}", c1); // 61

            c1 = a1 ^ b1;           /* 49 = 0011 0001 */
            Console.WriteLine("Line 3 - c 的值是 {0}", c1); // 49

            c1 = ~a1;               /*-61 = 1100 0011 */
            Console.WriteLine("Line 4 - c 的值是 {0}", c1); // -61

            c1 = a1 << 2;     /* 240 = 1111 0000 */
            Console.WriteLine("Line 5 - c 的值是 {0}", c1); // 240

            c1 = a1 >> 2;     /* 15 = 0000 1111 */
            Console.WriteLine("Line 6 - c 的值是 {0}", c1); // 15
            Console.ReadLine();
        }
    }
}
