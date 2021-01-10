using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public sealed override void Sleep()
        {
            Console.WriteLine("Dreaming for fayries.");
        }
    }
}
