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
             Item chair = new Item(1);
            FoodItem animalFood = new FoodItem(3);

            Shopping Guy1 = new Shopping();
            Guy1.Add_To_Cart(golden);
            Guy1.Add_To_Cart(orange);
            Guy1.Add_To_Cart(golden);
            Guy1.Add_To_Cart(animalFood);

            golden.price = 0.70;
            Console.WriteLine($"the bills is {Guy1.Bills()} euros");
            Console.ReadKey();
        }
    }

    abstract class Product
    {
        public double price { get; set; }

    }
    class Item : Product
    {
        public Item(int price)
        {
            this.price = price;

        }
    }

    abstract class Food : Product
    {

    }
    class FoodItem : Food
    {
        public FoodItem(int price)
        {
            this.price = price;
        }

    }
    abstract class Fruit : Food
    {

    }
    class Apple : Fruit
    {
        public Apple(double price)
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
        List<Product> cart = new List<Product>();
        public void Add_To_Cart(Product coconut)
        {
            cart.Add(coconut);
        }
        public double Bills()
        {
            double price = 0;
            foreach (Product banana in cart)
            {
                price += banana.price;
            }
            return price;
        }
    }

    class Price
    {
        public int price { get; set; }

    }
}
