using System;

namespace DemoThree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    throw new ArgumentException("I am ArgumentExceprion!");
                }
                catch (ArgumentException ae)
                {

                    throw new InvalidOperationException("I am invalid OE with inner AE!!!!!!!", ae);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
