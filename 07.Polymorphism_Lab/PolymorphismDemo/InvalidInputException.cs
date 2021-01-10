using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismDemo
{
    public class InvalidInputException : Exception
    {
        private const string INVALID_INPUT_EXC_MSG = "Invalid input!";

        public InvalidInputException() : base(INVALID_INPUT_EXC_MSG)
        {

        }
    }
}
