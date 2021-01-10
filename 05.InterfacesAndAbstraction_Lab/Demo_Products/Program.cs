using System;

namespace Demo_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            User user = new User();
            user.Money = 500;
            var nikeShoe = new Shoe() { Price = 55 };

            store.BuyProduct(nikeShoe, user);
            store.BuyProduct(new Shoe() { Price = 65}, user);
            //store.BuyProduct(new Toothbrush() { Price = 12}, user);
            //store.BuyProduct(new Microphone() { Price = 399}, user);
            //store.BuyProduct(new Human(), user);
            store.BuyProduct(new Microphone(), user);



        }
    }
}
