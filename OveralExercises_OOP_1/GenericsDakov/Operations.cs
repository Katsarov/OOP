using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDakov
{
    class Operations<T>
    {
        public T First { get; set; }

        public T Second { get; set; }


        public bool AreEqual(T first, T second)
        {
            return first.Equals(second);
        }

        public string ToStringResult(T first, T second)
        {
            return first.ToString() + second.ToString();
        }
    }
}
