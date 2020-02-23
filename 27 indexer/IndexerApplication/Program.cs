using System;

namespace IndexerApplication
{
    class IndexedName
    {
        private string[] nameList = new string[10];

        public string this[int index]
        {
            get
            {
                return this.nameList[index];
            }
            set
            {
                this.nameList[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexedName names = new IndexedName();
            names[0] = "zhangsan";
            Console.WriteLine(names[0]);
        }
    }
}
