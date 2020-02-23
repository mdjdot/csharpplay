using System;

namespace GenericApplication
{
    class Program
    {
        static public T Add<T>(T m, T n)
        {
            return m;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add("m", "n"));
        }
    }
}
