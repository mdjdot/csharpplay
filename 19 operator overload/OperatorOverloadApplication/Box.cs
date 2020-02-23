using System;

namespace OperatorOverloadApplication
{
    class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public static int operator +(Box b1, Box b2)
        {
            return b1.Length + b2.Length;
        }
    }
}