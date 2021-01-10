using System;
using System.Collections.Generic;

namespace DemoDebug
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            PrintSomeName("Kiril");
            Person person = new Child("Kiril");

            Console.WriteLine("Hello");

            List<int> numbers = new List<int>();
            //for (int i = 0; i < 30; i++)
            //{

            //    numbers.Add(i);
                
            //}

            Console.WriteLine(a);
        }

        public static void PrintSomeName(string name)
        {
            Console.WriteLine(name);
        }
    }

    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }

    public class Child : Person
    {
        public Child(string name) : base(name)
        {

        }
    }
}
