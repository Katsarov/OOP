using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomList
{
    public class List<T> : IEnumerable<T>
    {
        private T[] array;
        private int index = 0;

        public List()
        {
            array = new T[20];
        }

        public void Add(T element)
        {
            array[index++] = element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
