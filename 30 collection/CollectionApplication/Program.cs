using System;
using System.Collections;
namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("zhang");
            al.Add('c');
            al.Add(true);
            Console.WriteLine(al.Count);
            Console.WriteLine(al[2]);

            // HashTable
            Hashtable ht = new Hashtable();
            ht.Add(1, "zhang");
            ht.Add("二", "li");
            ht.Remove(1);
            Console.WriteLine(ht.Count);

            // Queue
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue('c');
            q.Dequeue();
            Console.WriteLine(q.Count);

            // Stack
            Stack s = new Stack();
            s.Push(1);
            s.Push('c');
            s.Pop();
            Console.WriteLine(s.Peek());
        }
    }
}
