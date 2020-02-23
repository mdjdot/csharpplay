using System;
using System.IO;

namespace FileInfoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@".\testdata");
            if (dir.Exists == false)
            {
                Directory.CreateDirectory(@".\testdata");
            }

            FileInfo[] files = dir.GetFiles();
            if (files.Length <= 0)
            {
                using (File.Create(@".\testdata\test.dat"))
                {

                }
            }
            files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
        }
    }
}
