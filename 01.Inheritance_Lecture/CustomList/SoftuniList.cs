
using System;

namespace CustomList
{
    class SoftuniList<T> : List<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("Adding -> " + item);
            base.Add(item);
        }
    }
}
