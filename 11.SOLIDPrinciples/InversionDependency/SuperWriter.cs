﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InversionDependency
{
    public class SuperWriter : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine($"SUPER: {text}");
        }
    }
}
