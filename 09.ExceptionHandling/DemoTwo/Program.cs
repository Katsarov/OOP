using System;

namespace DemoTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine().Substring(0, 2));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You have entered invalid number format!");
            }

            catch (OverflowException oe)
            {
                Console.WriteLine("The number is too big!");
            }

            catch (Exception e)
            {
                Console.WriteLine("The program has stopped working!");
            }
        }
    }
}
