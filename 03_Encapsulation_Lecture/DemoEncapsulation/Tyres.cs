using System;
using System.Collections.Generic;
using System.Text;

namespace DemoEncapsulation
{
    class Tyres
    {
        private int kilometers;

        public void Drive(int km)
        {
            kilometers += km;
        }

        public bool IsRubbish()
        {
            if (kilometers >= 20000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
