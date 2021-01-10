using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDakov
{
    public class Student<TAge, TName>
    {
        public TAge Age { get; set; }
        public TName Name { get; set; }
    }
}
