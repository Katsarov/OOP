using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExamples
{
    class Programmer : IWorker
    {
        public void PretendToBeSmart()
        {

        }

        public void EatPizza()
        {

        }

        public void Work()
        {
            Console.WriteLine("Slacking all day");
        }

        public void GetSalary()
        {
            Console.WriteLine("Undeserved");
        }
    }
}
