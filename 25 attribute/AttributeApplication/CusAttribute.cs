using System;
namespace AttributeApplication
{

    [AttributeUsage(AttributeTargets.Method)]
    class CusAttribute : Attribute
    {
        public string Level { get; set; }

        public CusAttribute(string level)
        {
            this.Level = level;
        }
        public void DoSomething()
        {
            Console.WriteLine("做了一些工作");
        }
    }
}