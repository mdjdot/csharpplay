using System;

namespace PolymorphicApplication
{
    class Rectangle : Sharp
    {
        private int length;
        private int width;

        public Rectangle(int length = 10, int width = 20)
        {
            this.length = length;
            this.width = width;
        }

        public override int area()
        {
            Console.WriteLine($"Rectangle 类的面积:{this.length * this.width}");
            return this.length * this.width;
        }
    }
}
