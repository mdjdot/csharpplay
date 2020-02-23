using System;

namespace PolymorphicApplication
{
    class Program
    {
        static int Add(int m, int n)
        {
            return m + n;
        }

        static int Add(double m, double n)
        {
            return (int)(m + n);
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            double c = 10.3;
            double d = 20.4;

            Console.WriteLine($"a + b = {Add(a, b)}");
            Console.WriteLine($"c + d = {Add(c, d)}");

            Rectangle rec = new Rectangle();
            Console.WriteLine(rec.area());

            VSharp vsharp = new VSharp();
            vsharp.Draw();
            VCircle vCircle = new VCircle();
            vCircle.Draw();
            VSharp vp1 = vCircle;
            vp1.Draw(); // 画一个圆形
        }
    }
}
