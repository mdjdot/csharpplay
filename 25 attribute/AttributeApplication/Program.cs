#define DEBUG
using System;
using System.Diagnostics;

namespace AttributeApplication
{
    class Program
    {
        [Conditional("DEBUG")]
        static void Message(string m)
        {
            Console.WriteLine(m);
        }

        [Obsolete("Don't use the Old Method, use New Method Addd instead")]
        static int Add(int m, int n)
        {
            return m + n;
        }

        [CusAttribute("BVT")]
        static int Addd(int m, int n)
        {
            return m + n;
        }

        static void Main(string[] args)
        {
#if (DEBUG)
            Console.WriteLine("debug 模式");
#else
            Console.WriteLine("非 debug 模式");
#endif

            int result = Add(12, 34);
            Console.WriteLine(result);

            int result1 = Addd(12, 35);
            Console.WriteLine(result1);
        }
    }
}
