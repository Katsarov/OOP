using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine(book[2]);

            // page 3 content
        }

        class Book
        {
            private string[] pages = new string[]
            {
                "page 1 content",
                "page 2 content",
                "page 3 content",
                "page 4 content"
            };

            // първо индексатор по страници
            public string this[int i]
            {
                get { return pages[i]; }
            }
        }
    }
}
