using System;

namespace LoopApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 循环
            int i = 1;
            for (; i < 11;)
            {
                Console.WriteLine(i);
                i++;
            }

            // foreach 循环
            int[] arr = new int[3] { 1, 2, 3 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            // while 循环
            int j = 11;
            while (j < 21)
            {
                Console.WriteLine(j);
                j++;
            }

            // do-while 循环
            int k = 1;
            do
            {
                Console.WriteLine("do-while");
                k++;
            } while (k < 11);
        }
    }
}
