using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {


            var worker = new Programmer();
            worker.Salary = 200;

            worker.Work();
            worker.Slack();

            Console.WriteLine(worker.ToString());
            Console.WriteLine(worker.Salary);
        }
    }
}
