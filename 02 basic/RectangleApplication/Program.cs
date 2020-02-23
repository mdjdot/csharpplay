using System;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;
        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length:\t{0}",length);
            Console.WriteLine($"Width:\t{width}");
            Console.WriteLine($"Area:\t{GetArea()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            rec.AcceptDetails();
            rec.Display();
            Console.ReadLine();
        }
    }
}
