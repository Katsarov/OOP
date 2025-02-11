﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    public class Tomcat : Cat
    {
        private const string TomcatGender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, TomcatGender)
        {
        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
