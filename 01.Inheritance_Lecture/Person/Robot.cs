using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Robot : Person
    {
        public override void Sleep()
        {
            throw new ArgumentException("Ne spi!");
        }
    }
}
