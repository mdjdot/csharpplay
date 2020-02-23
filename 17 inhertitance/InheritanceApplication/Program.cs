using System;

namespace InheritanceApplication
{
    class Sharp
    {
        private double length;
        private double width;

        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }
    }

    class Rectangle : Sharp
    {
        public double GetArea()
        {
            return this.Length * this.Width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sharp = new Rectangle();
            Console.WriteLine(sharp.Length); // 0
            Console.WriteLine(sharp.Width); // 0
            Console.WriteLine(sharp.GetArea()); // 0

            Rectangle rec = new Rectangle();
            rec.Length = 4.3;
            rec.Width = 5.4;
            Console.WriteLine(rec.Length); // 4.3
            Console.WriteLine(rec.Width); // 5.4
            Console.WriteLine(rec.GetArea()); // 23.22

            Sharp sp = rec;
            Console.WriteLine(sp.Length); // 4.3
            Console.WriteLine(sp.Width); // 5.4
        }
    }
}
