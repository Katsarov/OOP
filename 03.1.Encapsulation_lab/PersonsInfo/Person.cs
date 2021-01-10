using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LasttName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LasttName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if (Age <= 30)
            {
                this.Salary += (this.Salary * percentage) / 200;
            }
            else
            {
                this.Salary += (Salary * percentage) / 100;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LasttName} receives {Salary:f2} leva.";
        }
    }
}
