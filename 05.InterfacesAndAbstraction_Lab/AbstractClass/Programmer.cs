using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Programmer : Worker
    {
        public override int Salary { get; set; }
        public override void Work()
        {
            Console.WriteLine("Dnes ne rabotya");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Salary}");
            

            return sb.ToString().TrimEnd();
        }

        public override void GetSalary()
        {
            Console.WriteLine("The salary is too much!");
        }
    }
}
