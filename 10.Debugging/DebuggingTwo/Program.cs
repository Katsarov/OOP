using System;

namespace DebuggingTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = 5;
            A("Ivo");
        
        }

        public static void A(string name)
        {
            Console.WriteLine(name);
            B();
        }

        public static void B()
        {
            C();
        }

        public static void C()
        {
            D();
        }

        public static void D()
        {
            Console.WriteLine("D");
        }
    }
}
