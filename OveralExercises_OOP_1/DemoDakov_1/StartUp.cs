using System;

namespace DemoDakov_1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dog sharoDog = new Dog();

            sharoDog.Name = "Sharo";
            sharoDog.Age = 12;

            Console.WriteLine(sharoDog.Name);
            Console.WriteLine($"Age: {sharoDog.Age}");
            Console.WriteLine();

            Dog peshoDog = new Dog();
            peshoDog.Name = "Pesho";
            peshoDog.Age = 20;
            peshoDog.HadOwner = true;

            Console.WriteLine($"Name: {peshoDog.Name}");
            Console.WriteLine($"Age: {peshoDog.Age}");
            Console.WriteLine($"Had owner: {peshoDog.HadOwner}");
        }
    }
}
