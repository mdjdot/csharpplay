using System;

namespace StructApplication
{
    struct Book
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.title = "C# Programing";
            book.author = "Aolaen";
            book.subject = "some coding skills";
            book.book_id = 12;

            Console.WriteLine(book.title);
        }
    }
}
