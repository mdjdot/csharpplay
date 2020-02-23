using System;

namespace BranchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // if-else-if-else
            int a = 10;
            if (a < 10)
            {
                Console.WriteLine(9);
            }
            else if (a == 10)
            {
                Console.WriteLine(10);
            }
            else
            {
                Console.WriteLine(11);
            }

            // switch
            char A = 'A';
            switch (A)
            {
                case 'A':
                    Console.WriteLine('A');
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine('B');
                    break;
                default:
                    Console.WriteLine('D');
                    break;
            }
        }
    }
}
