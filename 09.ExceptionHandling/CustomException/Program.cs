
using CustomException.Exceptions;
using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 1 - когато конструктора е с аргументи, и ще сетнем узернейм и съобщение
            try
            {
                throw new MyInvalidUsernameException("Pesho", "It is not authenticated!");
            }
            catch (MyInvalidUsernameException miue)
            {

                Console.WriteLine($"{miue.Username} -> {miue.Message}");
            }

            catch (SystemException se)
            {
                Console.WriteLine(se.Message);
            }



            // Вариант 2 - когато конструктора е без аргументи

            //try
            //{
            //    throw new MyInvalidUsernameException();
            //}
            //catch (MyInvalidUsernameException miue)
            //{
            //    Console.WriteLine(miue);
            //}

            //catch (SystemException se)
            //{
            //    Console.WriteLine(se.Message);
            //}
        }
    }
}
