using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> grades = new SortedDictionary<string, int>();

            grades.Add("Dimitrichko", 6);
            grades.Add("Niki", 3);
            grades.Add("Pesho", 6);
            grades.Add("Ivan", 4);

            foreach (var item in grades)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
        }
    }
}
