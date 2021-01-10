using System;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniList<int> list = new SoftuniList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
