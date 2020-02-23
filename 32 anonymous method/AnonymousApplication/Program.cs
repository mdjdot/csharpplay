using System;

namespace AnonymousApplication
{
    delegate T Calc<T>(T m, T n);
    class Program
    {
        static void Main(string[] args)
        {
            Calc<int> calc = delegate (int n, int m)
            {
                return m + n;
            };

            Console.WriteLine(calc(4, 5));
        }
    }
}
