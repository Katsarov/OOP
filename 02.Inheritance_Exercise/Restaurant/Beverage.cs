using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
            //this.Price = price;
            //this.Name = name;
        }

        public double Milliliters { get; set; }

        //public string Name { get; set; }

        //public double Price { get; set; }
        //{
        //    set
        //    {
        //        this.Price = value;
        //    }
        //}
    }
}
