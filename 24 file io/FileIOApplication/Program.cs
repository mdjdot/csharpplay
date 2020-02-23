using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("./test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter w = new StreamWriter(f);

            for (int i = 1; i <= 20; i++)
            {
                w.WriteLine("数据：{0}", i);
            }
            w.Close();

            f = new FileStream("./test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader r = new StreamReader(f);
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(r.ReadLine());
            }
            r.Close();


            using (StreamReader r1 = new StreamReader("./test.dat"))
            {
                do
                {
                    string line = r1.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                    else
                    {
                        break;
                    }
                }
                while (true);
            }


        }
    }
}
