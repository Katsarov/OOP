using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Animal newAnimal = new Snake("Penka");
            //Console.WriteLine(newAnimal);

            //Animal animal;

            //string nameOfAnimal = Console.ReadLine();

            //Animal animal = new Animal("Ani");
            //Animal reptile = new Reptile("Repo");
            //Animal mammal = new Mammal("Mami");
            //Animal lizard = new Lizard("Lizi");
            //Animal snake = new Snake("Sisi");
            //Animal gorilla = new Gorilla("Geri");
            //Animal bear = new Bear("Bari");

            //if (nameOfAnimal == "Lizi")
            //{
            //    Console.WriteLine(lizard.GetType());
            //}

            Snake snake = new Snake("Pepi");
            Console.WriteLine(snake.Name);
        }
    }
}
