using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Talasum : Animal
    {
        public override void Eat(object food)
        {
            Console.WriteLine("Yam talasumska hrana");
        }

        public override void Sleep()
        {
            Console.WriteLine("Talasumstvam nasun :))))))");
        }
    }
}
