using System;
using System.Collections.Generic;
using System.Text;

namespace _01.InheritanceDemo
{
    public class FactoryWorker : Worker
    {
        public FactoryWorker() 
        {
            Console.WriteLine("In the FactoryWorker constructor");
        }

        public FactoryWorker(string factoryCompany) : base(factoryCompany)
        {
            Console.WriteLine("In the FactoryWorker constructor");
        }

        public void LeaveFactory()
        {
            Console.WriteLine("Leave factory!!!!");
            Console.WriteLine("Go home :)!");
            Console.WriteLine(Gender);
        }
    }
}
