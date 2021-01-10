using InterfaceExamples;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Worker : IWorker
    {
        public abstract int Salary { get; set; }
        public abstract void Work();

        public virtual void Slack()
        {
            Console.WriteLine("Slacking is cool!");
        }

        public abstract void GetSalary();
        
    }
}
