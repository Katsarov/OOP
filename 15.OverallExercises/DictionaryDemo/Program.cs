using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            foreach (var item in input)
            {
                if (count.ContainsKey(item))
                {
                    count[item] += 1;
                }
                else
                {
                    count.Add(item, 1);
                }
            }

            // Отпечатваме резултата
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
