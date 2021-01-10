using Internal;
using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            ShavingFoam foam = new ShavingFoam();
            foam.Name = "Gilette";
            

            Dog doggy = new Dog();
            doggy.Eat();
            doggy.Bark();

            Cat pissi = new Cat();
            pissi.Eat();
            pissi.Meow();
        }
    }
}
