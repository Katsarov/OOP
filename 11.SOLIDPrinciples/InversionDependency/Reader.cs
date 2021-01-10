using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependency
{
    public class Reader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
