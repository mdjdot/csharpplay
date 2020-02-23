using System;

namespace RecursionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1;i<11;i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        /*
            1, 2, 3, 5, 8
        */
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
