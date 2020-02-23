using System;

namespace DelegateApplication
{
    public delegate int Calc(int m, int n);
    class Program
    {
        static public int Add(int m, int n)
        {
            return m + n;
        }

        static public int Multi(int m, int n)
        {
            return m * n;
        }

        static void Main(string[] args)
        {
            Calc calc = new Calc(Add);
            Console.WriteLine(calc(3, 5));

            calc = new Calc(Multi);
            Console.WriteLine(calc(3, 5));

            Calc calcm = new Calc(Add);
            calcm += new Calc(Multi);
            Console.WriteLine(calcm(3, 5));
        }
    }
}
