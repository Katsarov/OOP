using System;

namespace PolymorphismDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Shape baseClass = null;

                if (input == "square")
                {
                    baseClass = new Square() { A = 3 };
                }
                else if (input == "rectangle")
                {
                    baseClass = new Rectangle() { A = 5, B = 6 };
                }
                else
                {
                    throw new InvalidInputException();
                }

            Console.WriteLine(baseClass.Area());
        }
    }
}
