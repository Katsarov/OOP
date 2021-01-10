using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException.Exceptions
{
    public class MyInvalidUsernameException : Exception
    {
        // Вариант 1 - конструктора е с аргументи, имаме и пропърти, което ще сетнем в главната програма
        public MyInvalidUsernameException(string username, string message) : base(message)
        {
            this.Username = username;
        }

        public string Username { get; set; }



        // Вариант 2 - конструктора е без аргументи

        //public MyInvalidUsernameException()
        //{

        //}
    }
}
