using System;

namespace InterfaceApplication
{
    interface ISharp
    {
        int GetArea(int m, int n);
    }

    class Rectangle : ISharp
    {
        public int GetArea(int m, int n)
        {
            Console.WriteLine("矩形面积为：{0}", m * n);
            return m * n;
        }
    }

    class Circle : ISharp
    {
        public int GetArea(int m, int n)
        {
            Console.WriteLine("圆形面积为：{0}", m * n * Math.PI);
            return (int)(m * n * Math.PI);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ISharp isharp = new Rectangle();
            isharp.GetArea(3,4);
        }
    }
}
