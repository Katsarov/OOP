using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependency
{
    public class Writer : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
