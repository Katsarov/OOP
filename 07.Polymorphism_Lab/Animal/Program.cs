using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Snake();
            Animal animal2 = new Cat();
            Animal animal3 = new Dog();

            //Human catLover = new Human(animal3);
            //Animal newAnimal = new Talasum();

            Human talasumche = new Human(new Talasum());

            while (true)
            {
                Console.ReadLine();
                talasumche.Feed();
                talasumche.PutToSleep();
            }


            //Human catLover = new Human(animal2);
            //Human snakeHater = new Human(animal);

            //while (true)
            //{
            //    Console.ReadLine();
            //    catLover.Feed();
            //    catLover.PutToSleep();
            //    //snakeHater.Feed();
            //    //snakeHater.PutToSleep();
            //}
        }
    }
}
