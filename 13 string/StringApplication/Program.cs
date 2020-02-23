using System;

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = "Rowan";
            string lName = "Atkinson";

            string fullName = fName + lName;
            Console.WriteLine($"Full name: {fullName}");

            string greeting = new string(new char[5] { 'H', 'e', 'l', 'l', 'o' });
            Console.WriteLine(greeting);

            string[] sArr = { "Hello", "world" };
            string message = string.Join(" ", sArr);
            Console.WriteLine(message);

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",
            waiting);
            Console.WriteLine($"Message: {chat}");
        }
    }
}
