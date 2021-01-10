using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("This is an exception!");
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
