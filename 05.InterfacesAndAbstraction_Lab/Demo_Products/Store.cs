using Demo_Products.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Products
{
    class Store
    {
        public void BuyProduct(IPrice product, User user)
        {
            decimal price = product.Price;
            if (user.Money < price)
            {
                throw new ArgumentException("Nyama kesh!!");
            }

            user.Money -= price;

            //if (product.Price > 0)
            //{
            //    Console.WriteLine($"Bought: " + product + $" for only : {price}");
            //}
            //else
            //{
            //    Console.WriteLine($"Bought: " + product);
            //}

            Console.WriteLine($"Bought: " + product + $" for only : {price}");
        }

        
    }
}
