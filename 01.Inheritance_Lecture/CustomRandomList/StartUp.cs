using System;
using System.Collections.Generic;
using System.Globalization;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("Gosho");
            list.Add("Pesho");
            list.Add("Tosho");
            list.Add("Kiril");

            Console.WriteLine(list.Count);

            Console.WriteLine(list.RandomString());

            Console.WriteLine(list.Count);
        }
    }
}
