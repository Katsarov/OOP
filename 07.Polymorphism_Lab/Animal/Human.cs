using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Human
    {
        public Human(Animal pet)
        {
            Pet = pet;
        }

        public Animal Pet { get; set; }

        public void Feed()
        {
            Pet.Eat("Jaz be");
        }

        public void PutToSleep()
        {
            Pet.Sleep();
        }
    }
}
