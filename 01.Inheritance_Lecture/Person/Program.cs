using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Sleep();
            
            Person child = new Child();
            child.Sleep();

            //Person robot = new Robot();
            //robot.Sleep();

            Baby baby = new Baby();
            baby.Sleep();

        }
    }
}
