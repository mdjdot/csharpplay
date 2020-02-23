using System;

namespace ArrayApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine(arr[3]); // 0

            for (int i = 0; i < 10; i++)
            {
                arr[i] = i + 10;
            }
            Console.WriteLine(arr); // System.Int32[]
            Console.WriteLine(arr[3]); // 13

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(arr);
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

            // 交错数组
            int[][] arrd = new int[2][] { new int[2] { 1, 2 }, new int[3] { 1, 2, 3 } };
            Console.WriteLine(arrd.Rank);
        }
    }
}
