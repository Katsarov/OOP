using System;

namespace MutablePrivateFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Human goshko = new Human();
            //goshko.Book.Name = "Vinetu";

            Console.WriteLine(goshko.Book.Name);

        }
    }
}
