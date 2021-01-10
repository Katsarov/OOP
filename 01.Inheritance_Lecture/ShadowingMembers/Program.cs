using System;

namespace ShadowingMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisEvent tenisEvent = new TennisEvent();

            tenisEvent.Print();
            Console.WriteLine(tenisEvent.Duration);


            tenisEvent.Start();

            Console.WriteLine(tenisEvent.ToString());

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
