using System;

namespace RecursionProperty
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Age);
        }
    }

    class Dog
    {
        private int age = 3;

        //public Dog(int age)
        //{
        //    this.Age = age;
        //}

        public int Age 
        { 
            get { return this.age; }
            set 
            {
                age = value;
            }
        }
    }
}
