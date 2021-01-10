using System;

namespace GenericMethodDakov
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Print(5);
            string text = Print("Name");
        }


        static T Print<T>(T value)
        {
            T value2 = value;
            Console.WriteLine(value);
            return value;
        }

    }
}
