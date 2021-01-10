using System;
using System.Collections.Generic;
using System.Text;

namespace _01.InheritanceDemo
{
    public class Worker : Person  // този Worker наследява Person и му взима пропъртитата Name i Age
    {
        public Worker()
        {
            Console.WriteLine("In the Empty worker constructor");
        }

        public Worker(string companyName)
        {
            Company = companyName;
            Console.WriteLine("In the Worker constructor for BMW");
        }

        public string Company { get; set; }

        public bool IsLazy { get { return true; }}  // по дифолт ни връща true :)
    }
}
