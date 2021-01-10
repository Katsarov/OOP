using System;

namespace _01.InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            FactoryWorker person = new FactoryWorker();
            FactoryWorker person2 = new FactoryWorker("BMW");

            //FactoryWorker factoryWorker = new FactoryWorker();
            //factoryWorker.Name = "Pesho";

            //Console.WriteLine(factoryWorker.Name);

            //factoryWorker.Sleep();

            //factoryWorker.LeaveFactory();

            //Console.WriteLine();

            //Student student = new Student();
            //student.Name = "Gosho";
            //Console.WriteLine(student.Name);
            //student.Eat();
        }
    }
}
