using System;

namespace ClassApplication
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        static public int a = 13;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                this.length = value;
            }
        }
        public double Breadth
        {
            get
            {
                return this.breadth;
            }
            set
            {
                this.breadth = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public Box()
        {
            Console.WriteLine("Box对象已创建");
        }
        public Box(double length, double breadth, double height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        ~Box()
        {
            Console.WriteLine("Box对象已删除");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Length = 4.23;
            box.Height = 2.34;
            box.Breadth = 3.45;
            Console.WriteLine($"box 的体积是{box.Length * box.Breadth * box.Height}"); // box 的体积是34.148790000000005
            Console.WriteLine($"box 的体积是{Math.Floor(box.Length * box.Breadth * box.Height)}"); // box 的体积是34
            Console.WriteLine($"box 的体积是{Math.Ceiling(box.Length * box.Breadth * box.Height)}"); // box 的体积是35

            Box box1 = new Box(2.1, 3.2, 3.4);
            Console.WriteLine($"box1 的体积是{box1.Length * box1.Breadth * box1.Height}"); // box1 的体积是22.848000000000003

            Console.WriteLine(Box.a); // 13
        }
    }
}
