using System;

namespace ParameterInOutApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            Swap(a, b);
            Console.WriteLine("在交换之后，a 的值： {0}", a);
            Console.WriteLine("在交换之后，b 的值： {0}", b);

            Swap(ref a, ref b);
            Console.WriteLine("在交换之后，a 的值： {0}", a);
            Console.WriteLine("在交换之后，b 的值： {0}", b);

            Update(out a, out b);
            Console.WriteLine("在更新之后，a 的值： {0}", a);
            Console.WriteLine("在更新之后，b 的值： {0}", b);
        }

        static void Swap(int n1, int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
        }

        static void Swap(ref int n1, ref int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
        }

        static void Update(out int n1, out int n2)
        {
            n1 = 10;
            n2 = 100;
        }
    }
}
