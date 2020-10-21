using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple golden = new Apple(0.60);
            Orange orange = new Orange(0.15);

            Shopping Guy1 = new Shopping();
            Guy1.Add_To_Cart(golden);
            Guy1.Add_To_Cart(orange);
            Guy1.Add_To_Cart(golden);

            Console.WriteLine($"the bills is {Guy1.Bills()} euros");
            Console.ReadKey();
        }
    }

    abstract class Fruit
    {
        public double price{ get; set; } 
    }
    class Apple : Fruit
    {
        public Apple (double price)
        {
            this.price = price;
        }
    }
    class Orange : Fruit
    {
        public Orange(double price)
        {
            this.price = price;
        }
    }


    class Shopping
    {
        List<Fruit> cart = new List<Fruit>();
        public void Add_To_Cart (Fruit coconut)
        {
            cart.Add(coconut);
        }
        public double Bills()
        {
            double price = 0;
            foreach (Fruit banana  in cart )
            {
                price += banana.price;
            }
            return price;
        }
    }
}
