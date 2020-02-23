using System;

namespace PolymorphicApplication
{
    class VSharp
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("执行基类的画图任务");
        }
    }
}
