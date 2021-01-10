using Demo_Products.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Products
{
    class Shoe : IPrice
    {
        public decimal Price { get; set; }

        public string Model { get; set; }

        public int Size { get; set; }
    }
}
