#define IsDebug
using System;

namespace PreProcessorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
#if (IsDebug)
            Console.WriteLine("已定义 IsDebug");
#else
            Console.WriteLine("未定义 IsDebug");
#endif
            #endregion
            Console.WriteLine("Hello World!");
        }
    }
}
