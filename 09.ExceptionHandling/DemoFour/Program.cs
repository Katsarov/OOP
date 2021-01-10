using System;

namespace DemoFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            try
            {
                if (n < 0)
                {
                    throw new FormatException("Number can not be a negative number!");
                }

                else if (n > 100)
                {
                    throw new OverflowException("Number is too big!");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch(OverflowException ofe)
            {
                Console.WriteLine(ofe.Message);
            }
        }
    }
}
