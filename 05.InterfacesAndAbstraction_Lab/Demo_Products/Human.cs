using Demo_Products.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Products
{
    class Human : IPrice
    {
        public decimal Price { get; set; }
    }
}
