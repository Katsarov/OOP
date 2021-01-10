using Demo_Products.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Products
{
    class Toothbrush : IPrice
    {
        public decimal Price { get; set; }

        public string Model { get; set; }

        public int Whitening { get; set; }
    }
}
