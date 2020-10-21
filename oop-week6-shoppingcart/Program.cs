using System;
using System.Collections.Generic;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }

    abstract class Fruit
    {
        public int price{ get; set; } 
    }
    class Apple : Fruit
    {
        public Apple (int price)
        {
            this.price = price;
        }
    }
    class Orange : Fruit
    {
        public Orange(int price)
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
        public int Bills()
        {
            int price = 0;
            foreach (Fruit banana  in cart )
            {
                price += banana.price;
            }
            return price;
        }
    }
}
