using System;

namespace InterfaceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = new Company();
            company.Workers.Add(new Programmer());
            company.Workers.Add(new Boss());
            company.Workers.Add(new Boss());
            company.Workers.Add(new FactoryMan());
            company.Workers.Add(new Boss());

            while (true)
            {
                var input = Console.ReadLine();
                company.WorkDay();
                if (input == "Salary")
                {
                    company.Salaryday();
                }
            }
        }
    }
}
