using System;
using System.Threading;

namespace MultipleThreadingApplication
{
    class Program
    {
        public static void DoSomething()
        {
            Console.WriteLine("a thread start");
        }
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine(th.CurrentCulture.LCID);

            ThreadStart threadStart = new ThreadStart(DoSomething);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Thread.Sleep(5 * 1000);
        }
    }
}
